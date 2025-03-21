using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    internal class FacultyManagementAddDL
    {
        public DataTable GetDesignations()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT lookup_id, value FROM lookup WHERE category = 'Designations'";
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
                emptyRow["value"] = "Select Designation";
                emptyRow["lookup_id"] = -1;
                dt.Rows.InsertAt(emptyRow, 0);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading designations: " + ex.Message);
            }
        }

        public void AddFaculty(string name, string email, string contact, int designationId, string researchArea, int teachingHours)
        {
            try
            {
                string query = "INSERT INTO faculty (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) " +
                               "VALUES (@name, @email, @contact, @designationId, @researchArea, @teachingHours, @userId)";

                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue("@designationId", designationId);
                        command.Parameters.AddWithValue("@researchArea", researchArea);
                        command.Parameters.AddWithValue("@teachingHours", teachingHours);
                        command.Parameters.AddWithValue("@userId", null);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding faculty: " + ex.Message);
            }
        }
    }
}
