using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DB_Mid_Project.DL; // Import the namespace where DatabaseHelper is defined

namespace DB_Mid_Project.UI
{
    public partial class UpdateRoom : Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
            LoadRooms(); // Load rooms when the form is initialized
            LoadRoomTypes(); // Load room types
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

        private void LoadRoomTypes()
        {
            room_type.Items.Add("Classroom");
            room_type.Items.Add("Lab");
            room_type.SelectedIndex = 0;
        }

        private void comboBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rooms.SelectedItem == null)
                return;

            int roomId = ((KeyValuePair<int, string>)rooms.SelectedItem).Key;

            LoadRoomDetails(roomId);
        }

        private void LoadRoomDetails(int roomId)
        {
            try
            {
                string query = $"SELECT room_name, room_type, capacity FROM rooms WHERE room_id = {roomId}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    if (reader.Read())
                    {
                        course_name.Text = reader.GetString("room_name");
                        room_type.SelectedItem = reader.GetString("room_type");
                        credit_hours.Text = reader.GetInt32("capacity").ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room details: " + ex.Message);
            }
        }

        private void add_course_Click(object sender, EventArgs e)
        {

            if (rooms.SelectedItem == null)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            int roomId = ((KeyValuePair<int, string>)rooms.SelectedItem).Key;

            string roomName = course_name.Text;
            string roomType = room_type.SelectedItem.ToString();
            int capacity = int.Parse(credit_hours.Text);

            try
            {
                string query = $"UPDATE rooms SET room_name = '{roomName}', room_type = '{roomType}', " +
                               $"capacity = {capacity} WHERE room_id = {roomId}";

                int rowsAffected = DatabaseHelper.Instance.Update(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room updated successfully!");

                    RoomManagement CMForm = new RoomManagement();
                    this.Hide();
                    CMForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoomManagement CMForm = new RoomManagement();
            this.Hide();
            CMForm.ShowDialog();
            this.Close();

        }
    }
}
