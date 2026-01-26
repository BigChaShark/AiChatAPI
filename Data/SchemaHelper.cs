using Microsoft.EntityFrameworkCore;
using System.Text;

public static class SchemaHelper
{
    public static string GetDatabaseSchema(DbContext db)
    {
        var sb = new StringBuilder();

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