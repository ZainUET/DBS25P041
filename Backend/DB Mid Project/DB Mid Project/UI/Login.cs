using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;
using DB_Mid_Project.UI;

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
                this.Hide();
                registerForm.ShowDialog();
                this.Close();
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
                forgotPassword forgotForm = new forgotPassword();
                this.Hide();
                forgotForm.ShowDialog();
                this.Close();
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

                int roleId = LoginDL.GetRoleId(selectedRole);
                if (roleId == -1)
                {
                    MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (LoginDL.AuthenticateUser(username, password, roleId))
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

        private void RedirectToDashboard(int roleId)
        {
            string role = LoginDL.GetRoleName(roleId);
            switch (role)
            {
                case "Admin":
                    AdministrativeStaffDashboard admindashboardForm = new AdministrativeStaffDashboard();
                    this.Hide();
                    admindashboardForm.ShowDialog();
                    this.Close();
                    break;
                case "Department Head":
                    DepartmentHeadDashborad departmentheaddashboardForm = new DepartmentHeadDashborad();
                    this.Hide();
                    departmentheaddashboardForm.ShowDialog();
                    this.Close();
                    break;
                case "Faculty":
                    int facultyId = LoginDL.GetFacultyIdFromUsername(textBox1.Text);
                    FacultyMembersDashboard facultydashboardForm = new FacultyMembersDashboard(facultyId);
                    this.Hide();
                    facultydashboardForm.ShowDialog();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Unauthorized access.");
                    break;
            }
        }

        private void LoadRoles()
        {
            DataTable roles = LoginDL.GetRoles();
            foreach (DataRow row in roles.Rows)
            {
                role.Items.Add(row["value"].ToString());
            }
        }
    }
}
