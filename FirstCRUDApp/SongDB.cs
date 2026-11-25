using Microsoft.Data.SqlClient;

namespace FirstCRUDApp;

public static class SongDB
{
    public static List<Song> GetAllSongs()
    {
        // Get connection to database
        SqlConnection con = new();
        con.ConnectionString = "Data Source=localhost;Initial Catalog=SongDb;Integrated Security=True;Trust Server Certificate=True;";

        // Open the connection to the database
        con.Open();

        return new List<Song>();
        // Prepare our SQL

        // Execute SQL

        // Read results and put data into a List<Song>

        // Return the list of songs
    }

    public static void AddSong(Song song)
    {
        throw new NotImplementedException();
    }

    public static void UpdateSong(Song song)
    {
        throw new NotImplementedException();
    }

    public static void DeleteSong(int songId)
    {
        throw new NotImplementedException();
    }
}
