using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RequestConsumables : Form
    {
        private int _facultyId;

        public RequestConsumables(int facultyId)
        {
            InitializeComponent();
            _facultyId = facultyId;
            LoadConsumables();
        }

        private void LoadConsumables()
        {
            try
            {
                consumables.Items.Clear(); // Clear previous items
                List<KeyValuePair<int, string>> consumableList = RequestConsumablesDL.GetConsumables();

                foreach (var consumable in consumableList)
                {
                    consumables.Items.Add(consumable);
                }

                consumables.DisplayMember = "Value";
                consumables.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (consumables.SelectedItem == null)
            {
                MessageBox.Show("Please select a consumable.");
                return;
            }

            if (!int.TryParse(conquantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int consumableId = ((KeyValuePair<int, string>)consumables.SelectedItem).Key;
            int statusId = 8; // Default status ID

            try
            {
                if (!RequestConsumablesDL.CheckStatusIdExists(statusId))
                {
                    MessageBox.Show("Invalid status ID. Please check the lookup table.");
                    return;
                }

                bool success = RequestConsumablesDL.SubmitRequest(_facultyId, consumableId, quantity, statusId);

                if (success)
                {
                    MessageBox.Show("Request submitted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to submit request.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyMembersDashboard showForm = new FacultyMembersDashboard(_facultyId);
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
