using System;
using System.Windows.Forms;
using DB_Mid_Project.DL;
using static DB_Mid_Project.DL.AddConsumableDL;

namespace DB_Mid_Project.UI
{
    public partial class AddConsumables : Form
    {
        public AddConsumables()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            try
            {
                int rowsAffected = ConsumableDL.AddConsumable(itemName);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Consumable added successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to add consumable.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding consumable: " + ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministrativeStaffDashboard dashboard = new AdministrativeStaffDashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
