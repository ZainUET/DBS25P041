using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class UpdateRoom : Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
            LoadRooms();
            LoadRoomTypes();
        }

        private void LoadRooms()
        {
            try
            {
                var roomsList = UpdateRoomDL.GetRooms();
                rooms.DataSource = new BindingSource(roomsList, null);
                rooms.DisplayMember = "Value";
                rooms.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadRoomTypes()
        {
            room_type.Items.Add("Classroom");
            room_type.Items.Add("Lab");
            room_type.SelectedIndex = 0;
        }

        private void rooms_SelectedIndexChanged(object sender, EventArgs e)
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
                DataRow roomData = UpdateRoomDL.GetRoomDetails(roomId);
                if (roomData != null)
                {
                    course_name.Text = roomData["room_name"].ToString();
                    room_type.SelectedItem = roomData["room_type"].ToString();
                    credit_hours.Text = roomData["capacity"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                int rowsAffected = UpdateRoomDL.UpdateRoom(roomId, roomName, roomType, capacity);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room updated successfully!");

                    RoomManagement showForm = new RoomManagement();
                    this.Hide();
                    showForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update room.");
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
