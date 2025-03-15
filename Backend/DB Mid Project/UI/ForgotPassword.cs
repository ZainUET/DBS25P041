using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DB_Mid_Project.DL;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace DB_Mid_Project
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }


        private bool IsValidEmail(string email)
        {
            // Simple email validation using regex
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsPasswordStrong(string password)
        {
            // Password must be at least 8 characters long and include uppercase, lowercase, and numbers
            return password.Length >= 8 &&
                   Regex.IsMatch(password, "[A-Z]") &&
                   Regex.IsMatch(password, "[a-z]") &&
                   Regex.IsMatch(password, "[0-9]");
        }

        private bool IsEmailExists(string email)
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

        private bool ResetPassword(string email, string passwordHash)
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

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            // Redirect to Login Form
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text.Trim();
            string newPassword = textBox2.Text.Trim();
            string confirmPassword = textBox1.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordStrong(newPassword))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, and numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email exists in the database
            if (!IsEmailExists(email))
            {
                MessageBox.Show("Email does not exist in our records!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the new password using BCrypt
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            // Update the password in the database
            if (ResetPassword(email, passwordHash))
            {
                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}