using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveRoom : Form
    {
        public RemoveRoom()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                rooms.Items.Clear(); // Clear previous items
                List<KeyValuePair<int, string>> roomList = RemoveRoomDL.GetRooms();

                foreach (var room in roomList)
                {
                    rooms.Items.Add(room);
                }

                rooms.DisplayMember = "Value";
                rooms.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (rooms.SelectedItem == null)
            {
                MessageBox.Show("Please select a room to remove.");
                return;
            }

            int roomId = ((KeyValuePair<int, string>)rooms.SelectedItem).Key;

            try
            {
                int rowsAffected = RemoveRoomDL.RemoveRoom(roomId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room removed successfully!");
                    rooms.Items.Remove(rooms.SelectedItem);
                    LoadRooms(); // Refresh the list
                }
                else
                {
                    MessageBox.Show("Failed to remove room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoomManagement showForm = new RoomManagement();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
