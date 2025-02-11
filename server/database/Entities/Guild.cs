using System.ComponentModel.DataAnnotations;

namespace database.Entities;

public class Guild
{
    [Key]
    public uint GuildID { get; set; }
    public uint LeaderID { get; set; }
    public string Name { get; set; }
}