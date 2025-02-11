using Microsoft.EntityFrameworkCore;

namespace database.Entities;

[PrimaryKey(nameof(PlayerID), nameof(RepID))]
public class Reputation
{
    public uint PlayerID { get; set; }
    public uint RepID { get; set; }
    public int Value { get; set; }
}