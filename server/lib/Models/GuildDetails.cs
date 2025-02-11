using lib.Models.DTOs;

namespace lib.Models;

public class GuildDetails
{
    public GuildDto Guild { get; set; }
    public List<GuildMemberDto> Members { get; set; }
}