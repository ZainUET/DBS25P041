using System;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class ShowRequestsDL
    {
        public static DataTable GetRequests(string statusFilter = "All")
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
                    SELECT r.request_id, f.name AS faculty_name, c.item_name, r.quantity, l.value AS status 
                    FROM faculty_requests r 
                    JOIN faculty f ON r.faculty_id = f.faculty_id 
                    JOIN consumables c ON r.item_id = c.consumable_id 
                    JOIN lookup l ON r.status_id = l.lookup_id";

                if (statusFilter != "All")
                {
                    query += $" WHERE l.value = '{statusFilter}'";
                }

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
                string query = "SELECT value FROM lookup WHERE category = 'RequestStatus'";
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
    }
}
