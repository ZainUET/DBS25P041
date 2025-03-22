using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class FulfilledRequest : Form
    {
        public FulfilledRequest()
        {
            InitializeComponent();
            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                requests.DataSource = FacultyRequestDL.GetPendingOrApprovedRequests();

                // Customize column headers for better readability
                requests.Columns["request_id"].HeaderText = "Request ID";
                requests.Columns["faculty_name"].HeaderText = "Faculty Name";
                requests.Columns["item_name"].HeaderText = "Item Name";
                requests.Columns["quantity"].HeaderText = "Quantity";
                requests.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (requests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request.");
                return;
            }

            int requestId = int.Parse(requests.SelectedRows[0].Cells["request_id"].Value.ToString());

            try
            {
                int fulfilledStatusId = FacultyRequestDL.GetStatusId("Fulfilled");
                if (fulfilledStatusId == -1)
                {
                    MessageBox.Show("Fulfilled status not found in the lookup table.");
                    return;
                }

                int rowsAffected = FacultyRequestDL.MarkRequestAsFulfilled(requestId, fulfilledStatusId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Request marked as fulfilled successfully!");
                    LoadRequests(); // Refresh data
                }
                else
                {
                    MessageBox.Show("Failed to mark request as fulfilled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministrativeStaffDashboard loginForm = new AdministrativeStaffDashboard();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
