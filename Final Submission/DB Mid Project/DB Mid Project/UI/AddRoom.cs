using System;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
            LoadRoomTypes();
        }

        private void LoadRoomTypes()
        {
            room_type.Items.Add("Classroom");
            room_type.Items.Add("Lab");
            room_type.SelectedIndex = 0;
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            string roomName = course_name.Text;
            string roomType = room_type.SelectedItem.ToString();

            if (!int.TryParse(credit_hours.Text, out int capacity))
            {
                MessageBox.Show("Invalid capacity. Please enter a number.");
                return;
            }

            try
            {
                int rowsAffected = RoomDL.AddRoom(roomName, roomType, capacity);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room added successfully!");
                    NavigateToRoomManagement();
                }
                else
                {
                    MessageBox.Show("Failed to add room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToRoomManagement();
        }

        private void NavigateToRoomManagement()
        {
            RoomManagement CMForm = new RoomManagement();
            this.Hide();
            CMForm.ShowDialog();
            this.Close();
        }
    }
}
