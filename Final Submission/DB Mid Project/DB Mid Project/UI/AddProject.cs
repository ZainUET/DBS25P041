using System;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            string title = course_name.Text;
            string description = richTextBox1.Text;

            try
            {
                int rowsAffected = ProjectDL.AddProject(title, description);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Project added successfully!");
                    NavigateToProjectManagement();
                }
                else
                {
                    MessageBox.Show("Failed to add project.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding project: " + ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToProjectManagement();
        }

        private void NavigateToProjectManagement()
        {
            ProjectManagement showForm = new ProjectManagement();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
