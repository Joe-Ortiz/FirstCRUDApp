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

        // Prepare our SQL
        SqlCommand selectCommand = new();
        selectCommand.Connection = con;
        selectCommand.CommandText =
            """
            SELECT Id
            , Genre
            , Artists
            , SongTitle
            , Album
            , NumberOfStreams
            , SongFileLocation 
            FROM Songs
            """;

        // Execute SQL
        SqlDataReader reader = selectCommand.ExecuteReader();

        // Read results and put data into a List<Song>
        List<Song> songs = new();
        while (reader.Read())
        {
            Song mySong = new()
            {
                Id = Convert.ToInt32(reader["Id"]),
                // Conditional/ternary operator to check if Genre is null in the database
                Genre = reader["Genre"] == DBNull.Value ? null : reader["Genre"].ToString(),
                Artists = [reader["Artists"].ToString() ?? string.Empty],
                // Set song title to value but if it's null use empty string instead. This is a null coalescing operator
                SongTitle = reader["SongTitle"].ToString() ?? string.Empty,
                Album = reader["Album"].ToString() ?? string.Empty,
                NumberOfStreams = Convert.ToUInt64(reader["NumberOfStreams"]),
                SongFileLocation = reader["SongFileLocation"].ToString() ?? string.Empty
            };

            songs.Add(mySong);
        }

        // Close the connection to the database
        con.Close();

        // Return the list of songs
        return songs;
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
