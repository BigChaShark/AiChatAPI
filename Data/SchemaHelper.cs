using AiChatAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

public static class SchemaHelper
{
    public static string GetDatabaseSchema(DbContext db, string enterpriseId)
    {
        //var sb = new StringBuilder();

        //// 1️⃣ ดึงรายชื่อ table ที่อนุญาตจาก DB
        //var allowedTables = db.Set<AllTable>()
        //    .Where(x => x.EnterPriseId == enterpriseId)
        //    .Select(x => x.TableName)
        //    .ToList();

        //// 2️⃣ วนเฉพาะ entity ที่อยู่ใน allowedTables
        //foreach (var entity in db.Model.GetEntityTypes())
        //{
        //    var tableName = entity.GetTableName();

        //    if (!allowedTables.Contains(tableName))
        //        continue;

        //    var columns = entity.GetProperties()
        //        .Select(p => $"{p.Name} ({p.ClrType.Name})");

        //    sb.AppendLine($"{tableName}({string.Join(", ", columns)})");
        //}
        return "";
        //return sb.ToString();
    }

    public static string GetDatabaseSchemaSaveone(DbContext db, int enterpriseId)
    {
        var sb = new StringBuilder();

        // 1️⃣ ดึงรายชื่อ table ที่อนุญาตจาก DB
        // 2️⃣ วนเฉพาะ entity ที่อยู่ใน allowedTables
        foreach (var entity in db.Model.GetEntityTypes())
        {
            var tableName = entity.GetTableName();

            var columns = entity.GetProperties()
                .Select(p => $"{p.Name} ({p.ClrType.Name})");

            sb.AppendLine($"{tableName}({string.Join(", ", columns)})");
        }

        return sb.ToString();
    }
}