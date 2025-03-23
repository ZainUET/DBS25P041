using System;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class ForgotPasswordDL
    {
        public static bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @email";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool ResetPassword(string email, string passwordHash)
        {
            string query = "UPDATE users SET password_hash = @passwordHash WHERE email = @email";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    command.Parameters.AddWithValue("@email", email);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
