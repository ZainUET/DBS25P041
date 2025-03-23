using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ShowSemesters : Form
    {
        public ShowSemesters()
        {
            InitializeComponent();
            LoadSemesters();
        }

        private void LoadSemesters()
        {
            try
            {
                DataTable dt = ShowSemestersDL.GetSemesters();
                dataGridViewsemesters.DataSource = dt;
                dataGridViewsemesters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
