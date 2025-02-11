namespace lib.Models;

public class SteamPlayerSummary
{
    public string SteamId { get; set; }
    public int ProfileState { get; set; }
    public int CommunityVisibilityState { get; set; }
    public ulong TimeCreated { get; set; }
}