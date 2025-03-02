using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
//using Lab2;



namespace DB_Mid_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void heading1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void role_Enter_1(object sender, EventArgs e)
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

        private void Login_Load_1(object sender, EventArgs e)
        {
            //LoadRoles();
            labelPlaceholder.ForeColor = Color.Gray;
            labelPlaceholder.BackColor = role.BackColor;
            labelPlaceholder.BringToFront();

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Register signupForm = new Register();
            signupForm.Show();
            this.Hide();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            forgotPassword Form = new forgotPassword();
            Form.Show();
            this.Hide();
        }



















        private void signup_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (role.SelectedItem == null) 
                {
                    MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                string selectedRoleName = role.SelectedItem.ToString(); 

                using (var conn = DatabaseHelper.Instance.getConnection())
                {
                    if (conn == null)  
                    {
                        MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    string roleQuery = "SELECT admin_role_id FROM faculty_admin_roles WHERE role_name = @roleName";
                    int selectedRoleId = -1;

                    using (var roleCmd = new MySqlCommand(roleQuery, conn))
                    {
                        roleCmd.Parameters.AddWithValue("@roleName", selectedRoleName);
                        object result = roleCmd.ExecuteScalar();

                        if (result != null)
                            selectedRoleId = Convert.ToInt32(result);
                        else
                        {
                            MessageBox.Show("Invalid role selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password AND role_id = @role_id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role_id", selectedRoleId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username, Password, or Role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









       




























    }














}
 
    















