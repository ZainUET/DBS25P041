using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ViewAssignedFacultyCourses : Form
    {
        public ViewAssignedFacultyCourses()
        {
            InitializeComponent();
            LoadFacultyCourses();
        }

        private void LoadFacultyCourses()
        {
            try
            {
                DataTable dt = ViewAssignedFacultyCoursesDL.GetFacultyCourses();
                dataGridViewFacultyCourses.DataSource = dt;
                dataGridViewFacultyCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
