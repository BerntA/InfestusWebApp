using database;
using database.Entities;
using Microsoft.EntityFrameworkCore;

namespace lib.Services;

public class KeyAuthService
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private static readonly Mutex _mutex = new();

    public KeyAuthService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<int> GetNumFreeSteamKeys()
    {
        try
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            var numKeys = await dbContext.Keys.CountAsync();
            return numKeys;
        }
        catch
        {
            return 0;
        }
    }

    public async Task<string?> GetSteamKeyForUser(ulong steamId)
    {
        try
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            var steamUser = await dbContext.Users.FindAsync(steamId);
            return steamUser?.Key;
        }
        catch
        {
            return null;
        }
    }

    public async Task<string?> RegisterSteamKeyForUser(ulong steamId)
    {
        _mutex.WaitOne();
        try
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            var steamUser = await dbContext.Users.FindAsync(steamId);
            if (steamUser is not null)
                return steamUser.Key; // this user already had a key!

            var steamKey = await dbContext.Keys.FirstOrDefaultAsync();
            if (steamKey is null)
                return null; // no keys available, skip!

            dbContext.Keys.Remove(steamKey);
            dbContext.Users.Add(new SteamUser
            {
                Id = steamId,
                Key = steamKey.Key,
            });

            await dbContext.SaveChangesAsync();
            return steamKey.Key;
        }
        catch
        {
            return null;
        }
        finally
        {
            _mutex.ReleaseMutex();
        }
    }
}