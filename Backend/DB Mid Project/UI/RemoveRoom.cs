using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
                string query = "SELECT room_id, room_name FROM rooms";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        rooms.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("room_id"),
                            reader.GetString("room_name")
                        ));
                    }
                }

                rooms.DisplayMember = "Value";
                rooms.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
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
                string query = $"DELETE FROM rooms WHERE room_id = {roomId}";
                int rowsAffected = DatabaseHelper.Instance.Update(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room removed successfully!");
                    rooms.Items.Remove(rooms.SelectedItem);

                    RoomManagement addForm = new RoomManagement();
                    this.Hide();
                    addForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to remove room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing room: " + ex.Message);
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
