using System.IO;
using AxisUNO.Database;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Windows.Storage;

namespace AxisUNO.Configurations.Database;

internal static class DatabaseConfiguration
{
    private const string DatabaseName = "AxisUNO.db";

    internal static DbContextOptions<DatabaseContext> GetOprions()
    {
        var builder = new DbContextOptionsBuilder<DatabaseContext>();

        builder.UseSqlite(GetConnectionString());

        return builder.Options;
    }

    private static string GetConnectionString()
    {
        var fullPath = Path.Combine(GetDatabaseLocation(), DatabaseName);

        return new SqliteConnectionStringBuilder()
        {
            DataSource = fullPath,
        }
        .ToString();
    }

    private static string GetDatabaseLocation()
    {
        return ApplicationData.Current.LocalFolder.Path;
    }
}