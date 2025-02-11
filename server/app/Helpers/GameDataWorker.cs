using lib.Services;

namespace app.Helpers;

public class GameDataWorker : BackgroundService
{
    private readonly SnapshotService _snapshotService;

    public GameDataWorker(SnapshotService snapshotService)
    {
        _snapshotService = snapshotService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(2500, stoppingToken);
        var nextUpdateAt = DateTime.MinValue;

        while (!stoppingToken.IsCancellationRequested)
        {
            if (DateTime.UtcNow <= nextUpdateAt)
            {
                await Task.Delay(30000, stoppingToken); // put the thread on hold while waiting
                continue;
            }

            try
            {
                _snapshotService.UpdateSnapshotList();
                _snapshotService.CopyGameDatabase();
            }
            catch
            {
                // ignored
            }

            nextUpdateAt = DateTime.UtcNow.AddHours(5);
        }
    }
}