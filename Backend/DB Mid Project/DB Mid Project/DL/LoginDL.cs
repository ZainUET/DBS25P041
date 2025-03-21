using System;
using System.Data;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace DB_Mid_Project.DL
{
    public class LoginDL
    {
        public static bool AuthenticateUser(string username, string password, int roleId)
        {
            string query = "SELECT password_hash FROM users WHERE username = @username AND role_id = @roleId";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@roleId", roleId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["password_hash"].ToString();
                            return BCrypt.Net.BCrypt.Verify(password, storedHash);
                        }
                    }
                }
            }
            return false;
        }

        public static int GetRoleId(string roleName)
        {
            string query = "SELECT lookup_id FROM lookup WHERE category = 'UserRoles' AND value = @roleName";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roleName", roleName);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public static string GetRoleName(int roleId)
        {
            string query = "SELECT value FROM lookup WHERE lookup_id = @roleId";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roleId", roleId);
                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public static int GetFacultyIdFromUsername(string username)
        {
            string query = "SELECT faculty.faculty_id FROM faculty JOIN users ON faculty.name = users.username WHERE users.username = @username";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public static DataTable GetRoles()
        {
            string query = "SELECT value FROM lookup WHERE category = 'UserRoles'";
            DataTable dt = new DataTable();
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
            return dt;
        }
    }
}
