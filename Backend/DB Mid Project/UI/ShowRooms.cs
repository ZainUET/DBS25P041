using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DB_Mid_Project.DL; // Import the namespace where DatabaseHelper is defined

namespace DB_Mid_Project.UI
{
    public partial class ShowRooms : Form
    {
        public ShowRooms()
        {
            InitializeComponent();
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            try
            {
                string query = "SELECT room_id, room_name, room_type, capacity FROM rooms";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    rooms.DataSource = dt;

                    rooms.Columns["room_id"].HeaderText = "Room ID";
                    rooms.Columns["room_name"].HeaderText = "Room Name";
                    rooms.Columns["room_type"].HeaderText = "Room Type";
                    rooms.Columns["capacity"].HeaderText = "Capacity";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room data: " + ex.Message);
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