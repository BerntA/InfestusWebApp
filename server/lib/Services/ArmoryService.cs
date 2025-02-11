using database;
using lib.Models;
using lib.Models.DTOs;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Text.RegularExpressions;

namespace lib.Services;

public class ArmoryService
{
    private readonly IDbContextFactory<GameDataDbContext> _dbContextFactory;
    private readonly IMemoryCache _memoryCache;

    public ArmoryService(IDbContextFactory<GameDataDbContext> dbContextFactory, IMemoryCache memoryCache)
    {
        _dbContextFactory = dbContextFactory;
        _memoryCache = memoryCache;
    }

    public async Task<List<PlayerDto>> GetPlayers()
    {
        return await _memoryCache.GetOrCreateAsync("game-data-players", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            using var dbContext = _dbContextFactory.CreateDbContext();
            var items = await dbContext.Characters.AsNoTracking().ToListAsync();
            return items.Adapt<List<PlayerDto>>();
        });
    }

    public async Task<List<GuildDto>> GetGuilds()
    {
        return await _memoryCache.GetOrCreateAsync("game-data-guilds", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            using var dbContext = _dbContextFactory.CreateDbContext();
            var items = await dbContext.Guilds.AsNoTracking().ToListAsync();
            return items.Adapt<List<GuildDto>>();
        });
    }

    public async Task<PlayerDetails?> GetPlayerDetails(string name)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || name.Length > 32)
            return null;

        name = Regex.Replace(name.ToLower(), "[^a-z]+", ""); // remove any whitespace, special chars, numbers, etc.

        if (string.IsNullOrEmpty(name))
            return null;

        return await _memoryCache.GetOrCreateAsync($"game-data-player-{name}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            using var dbContext = _dbContextFactory.CreateDbContext();

            var matches = await dbContext.Characters.AsNoTracking().Where(c => EF.Functions.Like(c.Name, $"%{name}%")).ToListAsync();
            var character = matches.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (character is null)
                return null;

            var guild = (character is null || character.GuildID == 0) ? null : await dbContext.Guilds.FindAsync(character.GuildID);

            var reputation = await dbContext.Reputation
                .AsNoTracking()
                .Where(rep => rep.PlayerID == character.PlayerID)
                .ToListAsync();

            return new PlayerDetails
            {
                Player = character.Adapt<PlayerDto>(),
                Guild = guild.Adapt<GuildDto>(),
                Reputation = reputation.Adapt<List<ReputationDto>>(),
            };
        });
    }

    public async Task<GuildDetails?> GetGuildDetails(string name)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || name.Length > 32)
            return null;

        name = Regex.Replace(name.ToLower().Trim(), "[^a-z ]+", ""); // only allow a-z and whitespace
        name = Regex.Replace(name.Trim(), "\\s\\s+", " "); // remove consecutive whitespace

        if (string.IsNullOrEmpty(name))
            return null;

        return await _memoryCache.GetOrCreateAsync($"game-data-guild-{name}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            using var dbContext = _dbContextFactory.CreateDbContext();

            var matches = await dbContext.Guilds.AsNoTracking().Where(c => EF.Functions.Like(c.Name, $"%{name}%")).ToListAsync();
            var guild = matches.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (guild is null)
                return null;

            var guildies = await dbContext.Characters
                    .AsNoTracking()
                    .Where(c => c.GuildID == guild.GuildID)
                    .ToListAsync();

            return new GuildDetails
            {
                Guild = guild.Adapt<GuildDto>(),
                Members = guildies.OrderByDescending(o => o.GuildRank).Adapt<List<GuildMemberDto>>(),
            };
        });
    }
}