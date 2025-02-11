using System.ComponentModel.DataAnnotations;

namespace database.Entities;

public class SteamKey
{
    [Key]
    public string Key { get; set; }
}