using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RoomDL
    {
        public static int AddRoom(string roomName, string roomType, int capacity)
        {
            string query = "INSERT INTO rooms (room_name, room_type, capacity) VALUES (@roomName, @roomType, @capacity)";

            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@roomName", roomName);
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    cmd.Parameters.AddWithValue("@capacity", capacity);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
