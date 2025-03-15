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
            LoadRoles(); // Populate the Role dropdown
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            // Redirect to Register Form
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            // Redirect to Forgot Password Form
            forgotPassword forgotPasswordForm = new forgotPassword();
            forgotPasswordForm.Show();
            this.Hide();
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
                string selectedRole = role.SelectedItem?.ToString(); // Get the selected role

                // Validate inputs
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

                // Get the role_id from the lookup table
                int roleId = GetRoleId(selectedRole);
                if (roleId == -1)
                {
                    MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Authenticate the user
                if (AuthenticateUser(username, password, roleId))
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirect to the appropriate dashboard based on the role
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
            return false; // Authentication failed
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
                    // Open Admin Dashboard
                    MessageBox.Show("Redirecting to Admin Dashboard.");
                    break;
                case "Department Head":
                    // Open Department Head Dashboard
                    MessageBox.Show("Redirecting to Department Head Dashboard.");
                    break;
                case "Faculty":
                    // Open Faculty Dashboard
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