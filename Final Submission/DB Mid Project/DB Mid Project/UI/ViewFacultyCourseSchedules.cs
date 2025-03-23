using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ViewFacultyCourseSchedules : Form
    {
        public ViewFacultyCourseSchedules()
        {
            InitializeComponent();
            LoadFacultyCourseSchedules();
        }

        private void LoadFacultyCourseSchedules()
        {
            try
            {
                List<ViewFacultyCourseSchedulesBL> scheduleList = ViewFacultyCourseSchedulesDL.GetFacultyCourseSchedules();
                dataGridViewFacultyCourseSchedules.DataSource = scheduleList;
                dataGridViewFacultyCourseSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty course schedules: " + ex.Message);
            }
        }

        

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyCourseScheduleManagement mainMenu = new FacultyCourseScheduleManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

    }
    
}
