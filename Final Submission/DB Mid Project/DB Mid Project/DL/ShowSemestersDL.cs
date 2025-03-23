using System;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class ShowSemestersDL
    {
        public static DataTable GetSemesters()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT semester_id AS 'ID', term AS 'Term', year AS 'Year' FROM semesters";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading semesters: " + ex.Message);
            }
            return dt;
        }
    }
}
