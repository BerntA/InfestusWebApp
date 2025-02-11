using System.ComponentModel.DataAnnotations;

namespace database.Entities;

public class Player
{
    [Key]
    public uint PlayerID { get; set; }

    public string Name { get; set; }
    public ulong SteamID { get; set; }

    public float PosX { get; set; }
    public float PosY { get; set; }
    public float PosZ { get; set; }
    public float YAW { get; set; }

    public uint Zone { get; set; }
    public string Map { get; set; }
    public uint Model { get; set; }
    public string SpawnPoint { get; set; }
    public uint Online { get; set; }
    public uint GroupID { get; set; }
    public uint InDungeon { get; set; }
    public uint World { get; set; }
    public uint GuildID { get; set; }
    public uint GuildRank { get; set; }
    public uint Level { get; set; }

    public uint Health { get; set; }
    public uint HealthMax { get; set; }
    public uint Drainer { get; set; }
    public uint DrainerMax { get; set; }

    public uint XPLeft { get; set; }
    public uint XPNeeded { get; set; }

    public uint Money { get; set; }
    public uint MoneyBank { get; set; }
    public bool BankAccess { get; set; }

    public uint Attribute1 { get; set; }
    public uint Attribute2 { get; set; }
    public uint Attribute3 { get; set; }
    public uint Attribute4 { get; set; }
    public uint PointsLeft { get; set; }

    public uint Head { get; set; }
    public uint Chest { get; set; }
    public uint Cloak { get; set; }
    public uint Gloves { get; set; }
    public uint Legs { get; set; }
    public uint Boots { get; set; }
    public uint Ring { get; set; }
    public uint Necklace { get; set; }
    public uint Trinket { get; set; }
    public uint PrimaryWeapon { get; set; }
    public uint SecondaryWeapon { get; set; }
    public uint MiscWeapon { get; set; }

    public uint Spell1 { get; set; }
    public uint Spell2 { get; set; }
    public uint Spell3 { get; set; }
    public uint Spell4 { get; set; }
    public uint Spell5 { get; set; }
    public uint Spell6 { get; set; }
    public uint Spell7 { get; set; }
    public uint Spell8 { get; set; }
}