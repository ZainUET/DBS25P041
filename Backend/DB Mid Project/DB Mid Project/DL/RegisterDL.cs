using System;
using System.Data;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace DB_Mid_Project.DL
{
    public class RegisterDL
    {
        public static bool IsUserExists(string username, string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @email";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
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

        public static bool RegisterUser(string username, string email, string passwordHash, int roleId)
        {
            string query = "INSERT INTO users (username, email, password_hash, role_id) VALUES (@username, @email, @passwordHash, @roleId)";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    command.Parameters.AddWithValue("@roleId", roleId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static DataTable LoadRoles()
        {
            DataTable rolesTable = new DataTable();
            string query = "SELECT value FROM lookup WHERE category = 'UserRoles'";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(rolesTable);
                    }
                }
            }
            return rolesTable;
        }
    }
}
