using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RequestDL
    {
        public static DataTable GetPendingRequests()
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
                    WHERE l.value = 'Pending'";

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

        public static DataTable GetStatuses()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT lookup_id, value FROM lookup WHERE category = 'RequestStatus' AND value IN ('Approved', 'Rejected')";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading statuses: " + ex.Message);
            }
            return dt;
        }

        public static int UpdateRequestStatus(int requestId, int statusId)
        {
            try
            {
                string query = $"UPDATE faculty_requests SET status_id = {statusId} WHERE request_id = {requestId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating request: " + ex.Message);
            }
        }
    }
}
