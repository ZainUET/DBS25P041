using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ShowRequests : Form
    {
        public ShowRequests()
        {
            InitializeComponent();
            LoadRequests();
            LoadStatuses();
        }

        private void LoadRequests(string statusFilter = "All")
        {
            try
            {
                DataTable dt = ShowRequestsDL.GetRequests(statusFilter);
                dataGridViewRequests.DataSource = dt;

                dataGridViewRequests.Columns["request_id"].HeaderText = "Request ID";
                dataGridViewRequests.Columns["faculty_name"].HeaderText = "Faculty Name";
                dataGridViewRequests.Columns["item_name"].HeaderText = "Item Name";
                dataGridViewRequests.Columns["quantity"].HeaderText = "Quantity";
                dataGridViewRequests.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStatuses()
        {
            try
            {
                comboBoxStatus.Items.Add("All"); // Default "All" option
                DataTable dt = ShowRequestsDL.GetStatuses();

                foreach (DataRow row in dt.Rows)
                {
                    comboBoxStatus.Items.Add(row["value"].ToString());
                }

                comboBoxStatus.SelectedIndex = 0; // Default selection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxStatus.SelectedItem?.ToString();
            LoadRequests(selectedStatus);
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyMembersDashboard showForm = new FacultyMembersDashboard(1);
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
