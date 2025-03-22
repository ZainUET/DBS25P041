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
    public partial class RoomManagement : Form
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DepartmentHeadDashborad AMForm = new DepartmentHeadDashborad();
            this.Hide();
            AMForm.ShowDialog();
            this.Close();
        }

        private void addmember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AddRoom addForm = new AddRoom();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            RemoveRoom addForm = new RemoveRoom();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void updatemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UpdateRoom updateForm = new UpdateRoom();
            this.Hide();
            updateForm.ShowDialog();
            this.Close();
        }

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowRooms showForm = new ShowRooms();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
