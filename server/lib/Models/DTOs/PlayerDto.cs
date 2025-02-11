namespace lib.Models.DTOs;

public class PlayerDto
{
    public string Name { get; set; }
    public string SteamID { get; set; }

    public uint Zone { get; set; }
    public uint Model { get; set; }
    public uint Level { get; set; }

    public uint GuildID { get; set; }
    public uint GuildRank { get; set; }

    public uint Health { get; set; }
    public uint HealthMax { get; set; }
    public uint Drainer { get; set; }
    public uint DrainerMax { get; set; }

    public uint Attribute1 { get; set; }
    public uint Attribute2 { get; set; }
    public uint Attribute3 { get; set; }
    public uint Attribute4 { get; set; }

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
}