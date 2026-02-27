
using AiChatAPI.Data;
using AiChatAPI.Models;
using AiChatAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Collections;

public class DbQueryService
{
    private readonly APIAIContext _db;

    public DbQueryService(APIAIContext db)
    {
        _db = db;
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
}

