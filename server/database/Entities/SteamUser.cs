using System.ComponentModel.DataAnnotations;

namespace database.Entities;

public class SteamUser
{
    [Key]
    public ulong Id { get; set; }
    public string Key { get; set; }
}