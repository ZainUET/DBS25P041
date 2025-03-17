using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DB_Mid_Project.DL;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Data;

namespace DB_Mid_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                Register registerForm = new Register();
                registerForm.Show();  
                this.Hide();          
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Register form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                forgotPassword forgotPasswordForm = new forgotPassword();
                forgotPasswordForm.Show();  
                this.Hide();              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Forgot Password form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void role_Enter(object sender, EventArgs e)
        {
            labelPlaceholder.Visible = false;
        }

        private void role_Leave(object sender, EventArgs e)
        {

            if (role.SelectedIndex == -1)
            {
                labelPlaceholder.Visible = true;
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                string selectedRole = role.SelectedItem?.ToString();  

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(selectedRole))
                {
                    MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int roleId = GetRoleId(selectedRole);
                if (roleId == -1)
                {
                    MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (AuthenticateUser(username, password, roleId))
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RedirectToDashboard(roleId);
                }
                else
                {
                    MessageBox.Show("Invalid Username, Password, or Role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, int roleId)
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

        private int GetRoleId(string roleName)
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

        private void RedirectToDashboard(int roleId)
        {
            string role = GetRoleName(roleId);
            switch (role)
            {
                case "Admin":
                    MessageBox.Show("Redirecting to Admin Dashboard.");
                    break;
                case "Department Head":
                    MessageBox.Show("Redirecting to Department Head Dashboard.");
                    break;
                case "Faculty":
                    MessageBox.Show("Redirecting to Faculty Dashboard.");
                    break;
                default:
                    MessageBox.Show("Unauthorized access.");
                    break;
            }
        }

        private string GetRoleName(int roleId)
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

        private void LoadRoles()
        {
            string query = "SELECT value FROM lookup WHERE category = 'UserRoles'";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            role.Items.Add(reader["value"].ToString());
                        }
                    }
                }
            }
        }
    }
}