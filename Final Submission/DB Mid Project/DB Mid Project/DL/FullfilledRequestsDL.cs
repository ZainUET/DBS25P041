using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class FacultyRequestDL
    {
        public static DataTable GetPendingOrApprovedRequests()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                    SELECT r.request_id, f.name AS faculty_name, c.item_name, r.quantity, l.value AS status 
                    FROM faculty_requests r 
                    JOIN faculty f ON r.faculty_id = f.faculty_id 
                    JOIN consumables c ON r.item_id = c.consumable_id 
                    JOIN lookup l ON r.status_id = l.lookup_id 
                    WHERE l.value IN ('Pending', 'Approved')";

                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading requests: " + ex.Message);
            }
            return dt;
        }

        public static int GetStatusId(string status)
        {
            try
            {
                string query = $"SELECT lookup_id FROM lookup WHERE category = 'RequestStatus' AND value = '{status}'";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32("lookup_id");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving status ID: " + ex.Message);
            }
            return -1;
        }

        public static int MarkRequestAsFulfilled(int requestId, int fulfilledStatusId)
        {
            try
            {
                string query = $"UPDATE faculty_requests SET status_id = {fulfilledStatusId} WHERE request_id = {requestId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error marking request as fulfilled: " + ex.Message);
            }
        }
    }
}
