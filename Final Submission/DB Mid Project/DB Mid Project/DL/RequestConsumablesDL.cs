using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RequestConsumablesDL
    {
        public static List<KeyValuePair<int, string>> GetConsumables()
        {
            List<KeyValuePair<int, string>> consumableList = new List<KeyValuePair<int, string>>();

            try
            {
                string query = "SELECT consumable_id, item_name FROM consumables";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        consumableList.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("consumable_id"),
                            reader.GetString("item_name")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading consumables: " + ex.Message);
            }

            return consumableList;
        }

        public static bool SubmitRequest(int facultyId, int consumableId, int quantity, int statusId)
        {
            try
            {
                string query = $"INSERT INTO faculty_requests (faculty_id, item_id, quantity, status_id) VALUES ({facultyId}, {consumableId}, {quantity}, {statusId})";
                int rowsAffected = DatabaseHelper.Instance.Update(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error submitting request: " + ex.Message);
            }
        }

        public static bool CheckStatusIdExists(int statusId)
        {
            try
            {
                string query = $"SELECT lookup_id FROM lookup WHERE lookup_id = {statusId} AND category = 'RequestStatus'";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking status ID: " + ex.Message);
            }
        }
    }
}
