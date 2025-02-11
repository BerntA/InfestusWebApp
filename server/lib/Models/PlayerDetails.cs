using lib.Models.DTOs;

namespace lib.Models;

public class PlayerDetails
{
    public PlayerDto Player { get; set; }
    public GuildDto? Guild { get; set; }
    public List<ReputationDto> Reputation { get; set; }
}