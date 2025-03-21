using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    internal class FacultyManagementShowDL
    {
        private readonly string connectionString;

        public FacultyManagementShowDL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetAllFaculty()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open(); // Explicitly open the connection
                    string query = @"
                        SELECT 
                            faculty_id AS 'Faculty ID',
                            name AS 'Name',
                            email AS 'Email',
                            contact AS 'Contact',
                            designation_id AS 'Designation ID',
                            research_area AS 'Research Area',
                            total_teaching_hours AS 'Teaching Hours'
                        FROM faculty";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching faculty data: " + ex.Message);
            }

            return dt;
        }
    }
}