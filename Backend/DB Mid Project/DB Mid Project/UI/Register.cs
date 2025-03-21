using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DB_Mid_Project.DL;
using BCrypt.Net;

namespace DB_Mid_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Login form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void role_Enter(object sender, EventArgs e)
        {
            labelPlaceholder.Visible = false;
        }

        private void role_Leave(object sender, EventArgs e)
        {
            if (Role.SelectedIndex == -1)
            {
                labelPlaceholder.Visible = true;
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string email = textBox3.Text.Trim();
            string password = textBox2.Text.Trim();
            string confirmPassword = textBox4.Text.Trim();
            string selectedRole = Role.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordStrong(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, and numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RegisterDL.IsUserExists(username, email))
            {
                MessageBox.Show("Username or Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            int roleId = RegisterDL.GetRoleId(selectedRole);
            if (roleId == -1)
            {
                MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RegisterDL.RegisterUser(username, email, passwordHash, roleId))
            {
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsPasswordStrong(string password)
        {
            return password.Length >= 8 &&
                   Regex.IsMatch(password, "[A-Z]") &&
                   Regex.IsMatch(password, "[a-z]") &&
                   Regex.IsMatch(password, "[0-9]");
        }

        private void LoadRoles()
        {
            DataTable rolesTable = RegisterDL.LoadRoles();
            foreach (DataRow row in rolesTable.Rows)
            {
                Role.Items.Add(row["value"].ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
