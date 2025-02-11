using database.Entities;
using Microsoft.EntityFrameworkCore;

namespace database;

public class GameDataDbContext : DbContext
{
    public GameDataDbContext(DbContextOptions<GameDataDbContext> options)
    : base(options)
    {
    }

    public DbSet<Player> Characters { get; set; }
    public DbSet<Guild> Guilds { get; set; }
    public DbSet<Reputation> Reputation { get; set; }
}