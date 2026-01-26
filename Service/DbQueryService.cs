
using AiChatAPI.Data;
using AiChatAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class DbQueryService
{
    private readonly AppDbContext _db;

    public DbQueryService(AppDbContext db)
    {
        _db = db;
    }

    private static readonly Dictionary<string, Type> AllowedTables =
    new()
    {
        { "Member", typeof(Member) },
        { "Wallet", typeof(Wallet) },
    };

    private IQueryable GetQueryable(string tableName)
    {
        if (!AllowedTables.TryGetValue(tableName, out var entityType))
            throw new Exception($"Table '{tableName}' not supported");

        var method = typeof(DbContext)
            .GetMethod(nameof(DbContext.Set), Type.EmptyTypes)!
            .MakeGenericMethod(entityType);

        return (IQueryable)method.Invoke(_db, null)!;
    }

    public async Task<object> Query(IntentResult intent, long? memberId)
    {
        // 1. ดึง DbSet ตามชื่อ table
        var queryable = GetQueryable(intent.Table);

        // 2. Apply MemberId filter (ถ้ามี)
        if (intent.UseMemberId && memberId.HasValue)
        {
            if (string.IsNullOrEmpty(intent.MemberIdField))
                throw new Exception("MemberIdField is required");

            var param = Expression.Parameter(queryable.ElementType, "x");
            var prop = Expression.Property(param, intent.MemberIdField);
            var body = Expression.Equal(
                prop,
                Expression.Constant(memberId.Value)
            );

            var lambda = Expression.Lambda(body, param);

            var whereMethod = typeof(Queryable)
                .GetMethods()
                .First(m => m.Name == "Where" && m.GetParameters().Length == 2)
                .MakeGenericMethod(queryable.ElementType);

            queryable = (IQueryable)whereMethod.Invoke(
                null,
                new object[] { queryable, lambda }
            )!;
        }

        // 3. Execute query
        var list = await EntityFrameworkQueryableExtensions
            .ToListAsync((dynamic)queryable);

        // 4. Project fields
        var result = new List<Dictionary<string, object?>>();

        foreach (var item in list)
        {
            var dict = new Dictionary<string, object?>();

            foreach (var field in intent.Fields)
            {
                var prop = item.GetType().GetProperty(field);
                if (prop != null)
                    dict[field] = prop.GetValue(item);
            }

            result.Add(dict);
        }

        return result;
    }
}

