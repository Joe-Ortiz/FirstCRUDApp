namespace FirstCRUDApp;

/// <summary>
/// Represents a single digital song
/// </summary>
public class Song
{
    // Auto -implemented properties
    public string Genre { get; set; }

    public List<string> Artists { get; set; }

    public string SongTitle { get; set; }

    public string Album { get; set; }

    public ulong NumberOfStreams { get; set; }

    /// <summary>
    /// The location points to a local path on the current
    /// machine. ex: C:\Music\Band_Name\SongFile.mp3
    /// All songs end with .mp3
    /// </summary>
    public string SongFileLocation { get; set; }
}