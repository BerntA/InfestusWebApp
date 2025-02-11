using database.Entities;
using Microsoft.EntityFrameworkCore;

namespace database;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<SteamKey> Keys { get; set; }
    public DbSet<SteamUser> Users { get; set; }
}