namespace FirstCRUDApp;

/// <summary>
/// Represents a single digital song
/// </summary>
public class Song
{
    /// <summary>
    /// The one genre the song belongs to
    /// </summary>
    public string? Genre { get; set; }

    /// <summary>
    /// The artists performing the song. Each element is one
    /// artist
    /// </summary>
    public List<string> Artists { get; set; } = [];

    /// <summary>
    /// Title of the song. English titles only
    /// </summary>
    public required string SongTitle { get; set; }

    /// <summary>
    /// The album the song belongs to
    /// </summary>
    public required string Album { get; set; }

    /// <summary>
    /// Number of times song has been streamed. A stream counts as
    /// a single play of at least 30 seconds of the song.
    /// </summary>
    public ulong NumberOfStreams { get; set; }

    /// <summary>
    /// The location points to a local path on the current
    /// machine. ex: C:\Music\Band_Name\SongFile.mp3
    /// All songs end with .mp3
    /// </summary>
    public required string SongFileLocation { get; set; }
}