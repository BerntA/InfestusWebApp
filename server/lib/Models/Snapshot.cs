using System.Globalization;

namespace lib.Models;

public class Snapshot
{
    public string File { get; set; }
    public DateTime CreatedAt { get; set; }

    public Snapshot(string file)
    {
        File = Path.GetFileName(file);
        var dateString = Path.GetFileNameWithoutExtension(file);
        CreatedAt = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
    }
}