using DB_Mid_Project.DL;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class ProjectDL
    {
        public static int AddProject(string title, string description)
        {
            string query = "INSERT INTO projects (title, description) VALUES (@title, @description)";

            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
