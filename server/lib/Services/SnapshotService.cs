using lib.Models;
using Microsoft.Extensions.Configuration;

namespace lib.Services;

public class SnapshotService
{
    public List<Snapshot> Snapshots { get; set; }
    private readonly string? _database;
    private readonly string? _targetDatabase;

    public SnapshotService(IConfiguration config)
    {
        Snapshots = [];
        _database = config["GameDatabase"];
        _targetDatabase = config["GameDatabaseFileTarget"];
    }

    /// <summary>
    /// Keep track of all available snapshots, so that clients can request which files to download.
    /// </summary>
    public void UpdateSnapshotList()
    {
        Snapshots.Clear();
        Directory.CreateDirectory("wwwroot/data/snapshots");

        var items = Directory
            .EnumerateFiles("wwwroot/data/snapshots", "*", SearchOption.TopDirectoryOnly)
            .Select(f => new Snapshot(f))
            .OrderByDescending(f => f.CreatedAt.Ticks);

        Snapshots = [.. items];
    }

    /// <summary>
    /// Back-end will copy over the latest game db file.
    /// </summary>
    public void CopyGameDatabase()
    {
        if (string.IsNullOrEmpty(_database) || string.IsNullOrEmpty(_targetDatabase) || !File.Exists(_targetDatabase))
            return;

        File.Copy(_targetDatabase, _database.Replace("Data Source=", ""), true);
    }
}