using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ShowFacultyRooms : Form
    {
        public ShowFacultyRooms()
        {
            InitializeComponent();
            LoadFacultyRoomAllocations();
        }

        private void LoadFacultyRoomAllocations()
        {
            try
            {
                List<FacultyRoomAllocation> allocations = ShowFacultyRoomsBL.GetFacultyRoomAllocations();

                // Convert list to DataTable for DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("Allocation ID", typeof(int));
                dt.Columns.Add("Faculty", typeof(string));
                dt.Columns.Add("Room", typeof(string));
                dt.Columns.Add("Term", typeof(string));
                dt.Columns.Add("Year", typeof(int));
                dt.Columns.Add("Reserved Hours", typeof(int));

                foreach (var allocation in allocations)
                {
                    dt.Rows.Add(allocation.AllocationId, allocation.FacultyName, allocation.RoomName, allocation.Term, allocation.Year, allocation.ReservedHours);
                }

                // Bind the DataTable to the DataGridView
                dataGridViewFacultyRoomAllocations.DataSource = dt;

                // Adjust column widths
                dataGridViewFacultyRoomAllocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty-room allocations: " + ex.Message);
            }
        }

        

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyRoomManagement mainMenu = new FacultyRoomManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();

        }
    }
}
