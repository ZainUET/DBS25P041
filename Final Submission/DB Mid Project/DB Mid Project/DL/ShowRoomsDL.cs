using System;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class ShowRoomsDL
    {
        public static DataTable GetRooms()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT room_id, room_name, room_type, capacity FROM rooms";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading room data: " + ex.Message);
            }
            return dt;
        }
    }
}
