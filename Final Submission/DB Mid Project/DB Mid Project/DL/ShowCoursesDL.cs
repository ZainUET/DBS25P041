using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class ShowCoursesDL
    {
        public static DataTable GetCourses()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT course_id, course_name, course_type, credit_hours, contact_hours FROM courses";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading course data: " + ex.Message);
            }
            return dt;
        }
    }
}
