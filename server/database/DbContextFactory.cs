using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Text.Json.Nodes;

namespace database;

public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlite(GetDatabaseConnectionString());
        return new ApplicationDbContext(optionsBuilder.Options);
    }

    private static string? GetDatabaseConnectionString()
    {
        var currentDir = Path.GetFullPath("../");
        var content = File.ReadAllText($"{currentDir}/app/appsettings.json");
        var config = JsonNode.Parse(content);

        if (config is null || config["AppDatabase"] is null)
            return null;

        return config["AppDatabase"]!.ToString();
    }
}