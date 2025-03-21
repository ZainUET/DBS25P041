using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    internal class FacultyManagementRemoveDL
    {
        public DataTable GetFacultyList()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT faculty_id, name FROM faculty";
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }

                DataRow emptyRow = dt.NewRow();
                emptyRow["name"] = "Select Faculty";
                emptyRow["faculty_id"] = -1;
                dt.Rows.InsertAt(emptyRow, 0);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading faculty members: " + ex.Message);
            }
        }

        public void DeleteFaculty(int facultyId)
        {
            try
            {
                string query = "DELETE FROM faculty WHERE faculty_id = @facultyId";
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@facultyId", facultyId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting faculty member: " + ex.Message);
            }
        }
    }
}
