using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ApproveRejectRequests : Form
    {
        public ApproveRejectRequests()
        {
            InitializeComponent();
            LoadRequests();
            LoadStatuses();
        }

        private void LoadRequests()
        {
            try
            {
                dataGridViewRequests.DataSource = RequestDL.GetPendingRequests();
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
                DataTable dt = RequestDL.GetStatuses();
                comboBoxStatus.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    comboBoxStatus.Items.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(row["lookup_id"]),
                        row["value"].ToString()
                    ));
                }
                comboBoxStatus.DisplayMember = "Value";
                comboBoxStatus.ValueMember = "Key";
                comboBoxStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request.");
                return;
            }

            int requestId = int.Parse(dataGridViewRequests.SelectedRows[0].Cells["request_id"].Value.ToString());
            int statusId = ((KeyValuePair<int, string>)comboBoxStatus.SelectedItem).Key;

            try
            {
                int rowsAffected = RequestDL.UpdateRequestStatus(requestId, statusId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Request updated successfully!");
                    LoadRequests();
                }
                else
                {
                    MessageBox.Show("Failed to update request.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DepartmentHeadDashborad loginForm = new DepartmentHeadDashborad();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
