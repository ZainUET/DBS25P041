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
    public partial class DepartmentHeadDashborad : Form
    {
        public DepartmentHeadDashborad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
