using lib.Services;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SnapshotController : ControllerBase
{
    private readonly SnapshotService _snapshotService;

    public SnapshotController(SnapshotService snapshotService)
    {
        _snapshotService = snapshotService;
    }

    [HttpGet]
    public IActionResult GetSnapshots()
    {
        var items = _snapshotService
            .Snapshots
            .Select(o => o.File)
            .ToList();
        return new OkObjectResult(items);
    }
}