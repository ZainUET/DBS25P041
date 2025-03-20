using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DB_Mid_Project.DL; // Import the namespace where DatabaseHelper is defined

namespace DB_Mid_Project.UI
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
            LoadRoomTypes(); // Load room types when the form is initialized
        }

        private void LoadRoomTypes()
        {
            // Add room types to the ComboBox
            room_type.Items.Add("Classroom");
            room_type.Items.Add("Lab");
            room_type.SelectedIndex = 0; // Default selection
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            string roomName = course_name.Text;
            string roomType = room_type.SelectedItem.ToString();
            int capacity = int.Parse(credit_hours.Text);

            try
            {
                // Insert the new room into the database
                string query = $"INSERT INTO rooms (room_name, room_type, capacity) " +
                               $"VALUES ('{roomName}', '{roomType}', {capacity})";

                int rowsAffected = DatabaseHelper.Instance.Update(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room added successfully!");

                    RoomManagement addForm = new RoomManagement();
                    this.Hide();
                    addForm.ShowDialog();
                    this.Close();
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
            RoomManagement CMForm = new RoomManagement();
            this.Hide();
            CMForm.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
