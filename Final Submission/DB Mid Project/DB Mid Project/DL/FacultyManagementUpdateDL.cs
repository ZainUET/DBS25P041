using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    internal class FacultyManagementUpdateDL
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

        public void UpdateFaculty(int facultyId, string name, string email, string contact, int designationId, string researchArea, int teachingHours)
        {
            try
            {
                string query = "UPDATE faculty SET name = @name, email = @email, contact = @contact, designation_id = @designationId, research_area = @researchArea, total_teaching_hours = @teachingHours WHERE faculty_id = @facultyId";
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
                        command.Parameters.AddWithValue("@facultyId", facultyId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating faculty member: " + ex.Message);
            }
        }
    }
}
