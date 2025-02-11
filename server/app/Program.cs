using app.Helpers;
using database;
using lib.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

static void RegisterDbContext<T>(IServiceCollection services, bool isDevBuild, string database) where T : DbContext
{
    services.AddDbContextFactory<T>(options =>
    {
        options.UseSqlite(database);
        options.EnableSensitiveDataLogging(isDevBuild);
        options.EnableDetailedErrors(isDevBuild);
    }, ServiceLifetime.Scoped);
}

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;
var isDevBuild = builder.Environment.IsDevelopment();

services.AddControllers();
services.AddHttpClient();
services.AddHttpContextAccessor();
services.AddMemoryCache();

services
    .AddRazorPages()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.AllowNamedFloatingPointLiterals;
        options.JsonSerializerOptions.IncludeFields = true;
    });

RegisterDbContext<ApplicationDbContext>(
    services, isDevBuild, config["AppDatabase"]
);

RegisterDbContext<GameDataDbContext>(
    services, isDevBuild, config["GameDatabase"]
);

services.AddHttpClient<SteamApiService>(options =>
{
    options.BaseAddress = new Uri(config["SteamApiUrl"]);
});

services.AddSingleton<SnapshotService>();
services.AddScoped<ArmoryService>();
services.AddScoped<KeyAuthService>();
services.AddHostedService<GameDataWorker>();

#if !DEBUG
builder.WebHost.UseUrls("http://0.0.0.0:8080");
#endif

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    //app.UseHsts();
}

app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions
{
    ServeUnknownFileTypes = true,
});
app.UseAntiforgery();

//app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();