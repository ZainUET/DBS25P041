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
    public partial class FacultyMembersDashboard : Form
    {
        private int _facultyId;

        public FacultyMembersDashboard(int facultyId)
        {
            InitializeComponent();
            _facultyId = facultyId;
        }




        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RequestConsumables requestForm = new RequestConsumables(_facultyId);
            this.Hide();
            requestForm.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowRequests requestForm = new ShowRequests();
            this.Hide();
            requestForm.ShowDialog();
            this.Close();


        }
    }
}
