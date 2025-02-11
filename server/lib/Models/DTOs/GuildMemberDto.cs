namespace lib.Models.DTOs;

public class GuildMemberDto
{
    public string Name { get; set; }
    public string SteamID { get; set; }
    public uint Zone { get; set; }
    public uint Level { get; set; }
    public uint GuildRank { get; set; }
}