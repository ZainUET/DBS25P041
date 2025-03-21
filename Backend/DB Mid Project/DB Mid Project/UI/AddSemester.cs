using System;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class AddSemester : Form
    {
        public AddSemester()
        {
            InitializeComponent();
            LoadTerms();
        }

        private void LoadTerms()
        {
            room_type.Items.Add("Spring");
            room_type.Items.Add("Summer");
            room_type.Items.Add("Fall");
            room_type.SelectedIndex = 0;
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            string term = room_type.SelectedItem.ToString();
            int year = int.Parse(numericUpDown1.Text);

            try
            {
                int rowsAffected = SemesterDL.AddSemester(term, year);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Semester added successfully!");
                    NavigateToSemesterManagement();
                }
                else
                {
                    MessageBox.Show("Failed to add semester.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding semester: " + ex.Message);
            }
        }

        private void NavigateToSemesterManagement()
        {
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SemesterManagement semesterForm = new SemesterManagement();
            this.Hide();
            semesterForm.ShowDialog();
            this.Close();

        }
    }
}
