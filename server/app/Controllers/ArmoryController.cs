using lib.Services;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArmoryController : ControllerBase
{
    private readonly ArmoryService _armoryService;

    public ArmoryController(ArmoryService armoryService)
    {
        _armoryService = armoryService;
    }

    [HttpGet("players")]
    public async Task<IActionResult> GetPlayers()
    {
        var items = await _armoryService.GetPlayers();
        return new OkObjectResult(items);
    }

    [HttpGet("guilds")]
    public async Task<IActionResult> GetGuilds()
    {
        var items = await _armoryService.GetGuilds();
        return new OkObjectResult(items);
    }

    [HttpGet("player/{id}")]
    public async Task<IActionResult> GetPlayerDetails(string id)
    {
        var playerData = await _armoryService.GetPlayerDetails(id);
        return (playerData is null) ? new NoContentResult() : new OkObjectResult(playerData);
    }

    [HttpGet("guild/{id}")]
    public async Task<IActionResult> GetGuildDetails(string id)
    {
        var guildData = await _armoryService.GetGuildDetails(id);
        return (guildData is null) ? new NoContentResult() : new OkObjectResult(guildData);
    }
}