using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RemoveRoomDL
    {
        public static List<KeyValuePair<int, string>> GetRooms()
        {
            List<KeyValuePair<int, string>> roomList = new List<KeyValuePair<int, string>>();

            try
            {
                string query = "SELECT room_id, room_name FROM rooms";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        roomList.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("room_id"),
                            reader.GetString("room_name")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading rooms: " + ex.Message);
            }

            return roomList;
        }

        public static int RemoveRoom(int roomId)
        {
            try
            {
                string query = $"DELETE FROM rooms WHERE room_id = {roomId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing room: " + ex.Message);
            }
        }
    }
}
