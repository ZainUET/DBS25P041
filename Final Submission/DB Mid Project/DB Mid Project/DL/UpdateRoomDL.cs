using System;
using System.Collections.Generic;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class UpdateRoomDL
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

        public static DataRow GetRoomDetails(int roomId)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT room_name, room_type, capacity FROM rooms WHERE room_id = {roomId}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading room details: " + ex.Message);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int UpdateRoom(int roomId, string roomName, string roomType, int capacity)
        {
            try
            {
                string query = $"UPDATE rooms SET room_name = '{roomName}', room_type = '{roomType}', " +
                               $"capacity = {capacity} WHERE room_id = {roomId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating room: " + ex.Message);
            }
        }
    }
}
