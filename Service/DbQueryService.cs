
using AiChatAPI.Data;
using AiChatAPI.Models;
using AiChatAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Collections;
using Newtonsoft.Json;
using System.Linq;

public class DbQueryService
{
    private readonly APIAIContext _db;
    private readonly Saveone saveoneContext;

    public DbQueryService(APIAIContext db, Saveone saveoneContext)
    {
        _db = db;
        this.saveoneContext = saveoneContext;
    }

    private IQueryable GetQueryable(string tableName, int enterPriseID)
    {
        // 1. ตรวจสอบสิทธิ์จาก AllTable
        var allowedTables = _db.Set<AllTable>()
            .Where(x => x.EnterPriseId == enterPriseID)
            .Select(x => x.TableName)
            .ToHashSet();

        if (!allowedTables.Contains(tableName))
            throw new Exception($"Table '{tableName}' not allowed for this enterprise.");

        // 2. หา entity type จาก EF model
        var entityType = _db.Model.GetEntityTypes()
            .FirstOrDefault(e => e.GetTableName() == tableName);

        if (entityType == null)
            throw new Exception($"Table '{tableName}' not found in DbContext.");

        var clrType = entityType.ClrType;

        var method = typeof(DbContext)
            .GetMethod(nameof(DbContext.Set), Type.EmptyTypes)!
            .MakeGenericMethod(clrType);

        return (IQueryable)method.Invoke(_db, null)!;
    }

    public async Task<object> Query(IntentResult intent, int enterPriseID)
    {
        if (intent.IntentType == "chat")
            return new { message = "No database query required." };
        var queryable = GetQueryable(intent.Table, enterPriseID);
        
        // ===== APPLY DYNAMIC FILTERS =====
        if (intent.Filters != null && intent.Filters.Any())
        {
            var param = Expression.Parameter(queryable.ElementType, "x");
            Expression? finalExpression = null;

            foreach (var filter in intent.Filters)
            {
                if (string.IsNullOrWhiteSpace(filter.Field))
                    continue;

                // Case-insensitive property search
                var propInfo = queryable.ElementType
                    .GetProperties()
                    .FirstOrDefault(p =>
                        p.Name.Equals(filter.Field, StringComparison.OrdinalIgnoreCase));

                if (propInfo == null)
                    continue;

                var left = Expression.Property(param, propInfo);
                Expression comparison;

                var operatorUpper = filter.Operator?.ToUpper() ?? "=";

                // ===== STRING TYPE =====
                if (propInfo.PropertyType == typeof(string))
                {
                    var value = filter.Value?.ToString()?.Trim() ?? "";

                    if (string.IsNullOrEmpty(value))
                        continue;

                    if (operatorUpper == "=")
                        operatorUpper = "LIKE";

                    var functions = Expression.Property(
                        null,
                        typeof(EF).GetProperty(nameof(EF.Functions))!
                    );

                    var likeMethod = typeof(DbFunctionsExtensions)
                        .GetMethod(
                            nameof(DbFunctionsExtensions.Like),
                            new[] { typeof(DbFunctions), typeof(string), typeof(string) }
                        )!;

                    var toStringMethod = typeof(string)
                        .GetMethod(nameof(string.ToString), Type.EmptyTypes)!;

                    Expression leftString = left.Type != typeof(string)
                        ? (Expression)Expression.Call(left, toStringMethod)
                        : (Expression)left;

                    var pattern = Expression.Constant($"%{value}%");

                    comparison = Expression.Call(
                        likeMethod,
                        functions,
                        leftString,
                        pattern
                    );
                }
                else
                {
                    // ===== NON STRING TYPE =====

                    var targetType = Nullable.GetUnderlyingType(propInfo.PropertyType)
                                     ?? propInfo.PropertyType;

                    var convertedValue = Convert.ChangeType(filter.Value, targetType);
                    var right = Expression.Constant(convertedValue);

                    comparison = operatorUpper switch
                    {
                        "=" => Expression.Equal(left, right),
                        ">" => Expression.GreaterThan(left, right),
                        "<" => Expression.LessThan(left, right),
                        ">=" => Expression.GreaterThanOrEqual(left, right),
                        "<=" => Expression.LessThanOrEqual(left, right),
                        _ => throw new Exception($"Operator '{filter.Operator}' not supported")
                    };
                }

                finalExpression = finalExpression == null
                    ? comparison
                    : Expression.AndAlso(finalExpression, comparison);
            }

            if (finalExpression != null)
            {
                var lambda = Expression.Lambda(finalExpression, param);

                var whereMethod = typeof(Queryable)
                    .GetMethods()
                    .First(m => m.Name == "Where" && m.GetParameters().Length == 2)
                    .MakeGenericMethod(queryable.ElementType);

                queryable = (IQueryable)whereMethod.Invoke(
                    null,
                    new object[] { queryable, lambda }
                )!;
            }
        }
        Console.WriteLine("......................................"+queryable.ToQueryString());

        // ===== EXECUTE QUERY =====
        var toListAsyncMethod = typeof(EntityFrameworkQueryableExtensions)
        .GetMethods()
        .First(m =>
            m.Name == "ToListAsync" &&
            m.GetParameters().Length == 2) // source + cancellationToken
        .MakeGenericMethod(queryable.ElementType);

            var task = (Task)toListAsyncMethod.Invoke(
                null,
                new object[] { queryable, CancellationToken.None }
            )!;

            await task;

        var resultProperty = task.GetType().GetProperty("Result")!;
        var list = (IEnumerable<object>)resultProperty.GetValue(task)!;

        // ===== PROJECT FIELDS =====
        var result = new List<Dictionary<string, object?>>();

        foreach (var item in list)
        {
            var dict = new Dictionary<string, object?>();

            if (intent.Fields == null || !intent.Fields.Any())
            {
                // ถ้า AI ไม่เลือก fields  return ทั้ง row
                foreach (var prop in item.GetType().GetProperties())
                    dict[prop.Name] = prop.GetValue(item);
            }
            else
            {
                foreach (var field in intent.Fields)
                {
                    var prop = item.GetType()
                        .GetProperties()
                        .FirstOrDefault(p =>
                            p.Name.Equals(field, StringComparison.OrdinalIgnoreCase));

                    if (prop != null)
                        dict[prop.Name] = prop.GetValue(item);
                }
            }

            result.Add(dict);
        }

        return result;
    }

    public async Task<object> Compare(IntentResult intent, int enterPriseID)
    {
        if (string.IsNullOrEmpty(intent.CompareField))
            throw new Exception("CompareField is required.");

        var queryable = GetQueryable(intent.Table, enterPriseID);

        // ===== ใช้ Query Logic เดิมของคุณ =====
        if (intent.Filters != null && intent.Filters.Any())
        {
            var param = Expression.Parameter(queryable.ElementType, "x");
            Expression? finalExpression = null;

            foreach (var filter in intent.Filters)
            {
                var propInfo = queryable.ElementType
                    .GetProperties()
                    .FirstOrDefault(p =>
                        p.Name.Equals(filter.Field, StringComparison.OrdinalIgnoreCase));

                if (propInfo == null)
                    continue;

                var left = Expression.Property(param, propInfo);
                Expression comparison;

                var operatorUpper = filter.Operator?.ToUpper() ?? "=";

                // ===== STRING TYPE → ใช้ LIKE =====
                if (propInfo.PropertyType == typeof(string))
                {
                    var value = filter.Value?.ToString()?.Trim() ?? "";

                    if (string.IsNullOrEmpty(value))
                        continue;

                    var functions = Expression.Property(
                        null,
                        typeof(EF).GetProperty(nameof(EF.Functions))!
                    );

                    var likeMethod = typeof(DbFunctionsExtensions)
                        .GetMethod(
                            nameof(DbFunctionsExtensions.Like),
                            new[] { typeof(DbFunctions), typeof(string), typeof(string) }
                        )!;

                    var pattern = Expression.Constant($"%{value}%");

                    comparison = Expression.Call(
                        likeMethod,
                        functions,
                        left,
                        pattern
                    );
                }
                else
                {
                    // ===== NON STRING TYPE =====
                    var targetType = Nullable.GetUnderlyingType(propInfo.PropertyType)
                                     ?? propInfo.PropertyType;

                    var convertedValue = Convert.ChangeType(filter.Value, targetType);
                    var right = Expression.Constant(convertedValue);

                    comparison = operatorUpper switch
                    {
                        "=" => Expression.Equal(left, right),
                        ">" => Expression.GreaterThan(left, right),
                        "<" => Expression.LessThan(left, right),
                        ">=" => Expression.GreaterThanOrEqual(left, right),
                        "<=" => Expression.LessThanOrEqual(left, right),
                        _ => throw new Exception($"Operator '{filter.Operator}' not supported")
                    };
                }

                finalExpression = finalExpression == null
                    ? comparison
                    : Expression.OrElse(finalExpression, comparison);
            }

            if (finalExpression != null)
            {
                var lambda = Expression.Lambda(finalExpression, param);

                var whereMethod = typeof(Queryable)
                    .GetMethods()
                    .First(m => m.Name == "Where" && m.GetParameters().Length == 2)
                    .MakeGenericMethod(queryable.ElementType);

                queryable = (IQueryable)whereMethod.Invoke(
                    null,
                    new object[] { queryable, lambda }
                )!;
            }
        }

        // ===== Execute Query =====
        var toListAsyncMethod = typeof(EntityFrameworkQueryableExtensions).GetMethods().First(m =>m.Name == "ToListAsync" && m.GetParameters().Length == 2).MakeGenericMethod(queryable.ElementType);

        var task = (Task)toListAsyncMethod.Invoke(
            null,
            new object[] { queryable, CancellationToken.None }
        )!;

        await task;

        var resultProperty = task.GetType().GetProperty("Result")!;
        var list = ((IEnumerable<object>)resultProperty.GetValue(task)!).ToList();

        if (!list.Any())
            return new { message = "ไม่พบข้อมูลสำหรับเปรียบเทียบ" };

        // ===== หา CompareField =====
        var compareProp = queryable.ElementType
            .GetProperties()
            .FirstOrDefault(p =>
                p.Name.Equals(intent.CompareField, StringComparison.OrdinalIgnoreCase));

        if (compareProp == null)
            throw new Exception("CompareField not found.");

        var compareResults = list
            .Select(item => new
            {
                Item = item,
                Value = Convert.ToDecimal(compareProp.GetValue(item) ?? 0)
            })
            .ToList();

        var maxItem = compareResults.OrderByDescending(x => x.Value).First();
        var minItem = compareResults.OrderBy(x => x.Value).First();

        return new
        {
            highest = maxItem.Item,
            lowest = minItem.Item,
            all = list
        };
    }

    #region SAVEONE
    public string QuerySaveone(string lineUser)
    {
        var member = saveoneContext.SaveoneGoMembers
            .FirstOrDefault(x => x.LineUserId == lineUser);
        var memMain = saveoneContext.Members.FirstOrDefault(x => x.Id == member.MemberId);

        if (member == null)
            return JsonConvert.SerializeObject(null);

        // -------------------------------
        // 1. โหลด FoodCategory (กัน OPENJSON)
        // -------------------------------
        var foodCatIds = saveoneContext.FoodCategories
            .Select(f => f.FoodCategoryUseId)
            .ToList();

        // -------------------------------
        // 2. รวม Market ทั้งหมด
        // -------------------------------
        var allMarkets = new List<dynamic>();

        // Robinson (Zone 3)
        allMarkets.AddRange(
            saveoneContext.SaveoneGoMemberRobinsons
                .AsEnumerable()
                .Where(m => m.Status >= 1
                    && m.SaveoneGoZoneMarketId == 3
                    && m.MemberId == member.MemberId
                    && foodCatIds.Contains(m.ShopType))
                .Select(m => new
                {
                    ZoneID = m.SaveoneGoZoneMarketId,
                    RankNo = m.RankNo,
                    Score = m.Score
                }).ToList()
        );

        // Flea Market
        allMarkets.AddRange(
            saveoneContext.SaveoneGoMemberFleaMarkets
                .Where(m => m.MemberId == member.MemberId)
                .Select(m => new
                {
                    ZoneID = m.ZoneId,
                    RankNo = m.RankNo,
                    Score = m.Score
                }).ToList()
        );

        // BKK Street Food
        allMarkets.AddRange(
            saveoneContext.SaveoneGoMembers
                .AsEnumerable()
                .Where(m => !string.IsNullOrEmpty(m.ShopName)
                    && foodCatIds.Contains(m.IsFood)
                    && m.MemberId == member.MemberId)
                .Select(m => new
                {
                    ZoneID = 1,
                    RankNo = m.RankNo,
                    Score = m.Score
                }).ToList()
        );

        // Bangna Street Food (Zone 5)
        allMarkets.AddRange(
            saveoneContext.SaveoneGoMemberRobinsons
                .Where(m => m.Status >= 1
                    && m.SaveoneGoZoneMarketId == 5
                    && m.MemberId == member.MemberId)
                .Select(m => new
                {
                    ZoneID = m.SaveoneGoZoneMarketId,
                    RankNo = m.RankNo,
                    Score = m.Score
                }).ToList()
        );

        // Bangna Flea (Zone 6)
        allMarkets.AddRange(
            saveoneContext.SaveoneGoMemberRobinsons
                .Where(m => m.Status >= 1
                    && m.SaveoneGoZoneMarketId == 6
                    && m.MemberId == member.MemberId)
                .Select(m => new
                {
                    ZoneID = m.SaveoneGoZoneMarketId,
                    RankNo = m.RankNo,
                    Score = m.Score
                }).ToList()
        );

        // -------------------------------
        // 3. Wallet
        // -------------------------------
        var wallet = saveoneContext.Sgsavings
            .Where(x => x.MemberId == member.MemberId)
            .Select(x => x.BalanceAmount)
            .FirstOrDefault();

        // -------------------------------
        // 4. โหลด Master Data (กัน OPENJSON)
        // -------------------------------
        var zoneIds = allMarkets
            .Select(x => (int)x.ZoneID)
            .Distinct()
            .ToList();

        var zoneMarkets = saveoneContext.SaveoneGoZoneMarkets
            .AsEnumerable() // 🔥 กัน OPENJSON
            .Where(z => zoneIds.Contains(z.Id))
            .ToList();

        var rankings = saveoneContext.SaveoneGoRankings
            .AsEnumerable() // 🔥 กัน OPENJSON
            .Where(r => r.SaveoneGoZoneMarketId.HasValue
                && zoneIds.Contains(r.SaveoneGoZoneMarketId.Value))
            .ToList();

        // -------------------------------
        // 5. Map ลง Model
        // -------------------------------
        var marketData = allMarkets
            .AsEnumerable()
            .Select(m =>
            {
                var zone = zoneMarkets
                    .FirstOrDefault(z => z.Id == m.ZoneID);

                var rank = rankings
                    .FirstOrDefault(r =>
                        r.SaveoneGoZoneMarketId == m.ZoneID &&
                        m.RankNo >= r.RankingStart &&
                        m.RankNo <= r.RankingEnd);

                return new SaveoneMarketData
                {
                    MarketName = zone?.Name ?? "",
                    Rank = m.RankNo,
                    Score = m.Score,

                    // ⭐ แปลง RankName → int
                    Star = rank?.RankName,

                    // 🕒 เวลา
                    ReservationTimeStart = rank?.TimeStart?.ToString("HH:mm") ?? "",
                    ReservationTimeEnd = rank?.TimeEnd?.ToString("HH:mm") ?? ""
                };
            })
            .ToList();

        // -------------------------------
        // 6. Final Result
        // -------------------------------
        var result = new SaveoneInfoData
        {
            Name = memMain.Name ?? member.BankName,
            WalletBalance = wallet ?? 0,
            MarketData = marketData
        };

        Debug.WriteLine("Saveone Result: " + JsonConvert.SerializeObject(result));

        return JsonConvert.SerializeObject(result);
    }
    #endregion


}

