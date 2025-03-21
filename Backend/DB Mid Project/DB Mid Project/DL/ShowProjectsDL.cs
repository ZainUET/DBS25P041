using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class ShowProjectsDL
    {
        public static DataTable GetProjects()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT project_id, title, description FROM projects";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading project data: " + ex.Message);
            }
            return dt;
        }
    }
}
