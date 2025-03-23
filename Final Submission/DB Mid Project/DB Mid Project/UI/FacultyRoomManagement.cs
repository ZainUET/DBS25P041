using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Mid_Project.UI
{
    public partial class FacultyRoomManagement : Form
    {
        public FacultyRoomManagement()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministrativeStaffDashboard AMForm = new AdministrativeStaffDashboard();
            this.Hide();
            AMForm.ShowDialog();
            this.Close();
        }

        private void addmember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AllocateRoomToFaculty addForm = new AllocateRoomToFaculty();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            RemoveFacultyRoom addForm = new RemoveFacultyRoom();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFacultyRooms showForm = new ShowFacultyRooms();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
