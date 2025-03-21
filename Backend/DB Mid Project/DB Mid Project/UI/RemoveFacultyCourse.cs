using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveFacultyCourse : Form
    {
        public RemoveFacultyCourse()
        {
            InitializeComponent();
            LoadFacultyCourses();
        }

        private void LoadFacultyCourses()
        {
            try
            {
                dataGridViewFacultyCourses.DataSource = RemoveFacultyCourseDL.GetFacultyCourses();
                dataGridViewFacultyCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewFacultyCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty-course assignment to remove.");
                return;
            }

            int facultyCourseId = (int)dataGridViewFacultyCourses.SelectedRows[0].Cells["faculty_course_id"].Value;

            try
            {
                int rowsAffected = RemoveFacultyCourseDL.RemoveFacultyCourse(facultyCourseId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Faculty-course assignment removed successfully!");
                    LoadFacultyCourses(); // Refresh table
                }
                else
                {
                    MessageBox.Show("Failed to remove faculty-course assignment.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyCoursesManagement mainMenu = new FacultyCoursesManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
