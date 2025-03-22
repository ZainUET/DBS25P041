using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class AllocateRoomToFaculty : Form
    {
        private List<Faculty> facultyList;
        private List<Room> roomList;
        private List<Semester> semesterList;

        public AllocateRoomToFaculty()
        {
            InitializeComponent();
            LoadFaculty();
            LoadRooms();
            LoadSemesters();
        }

        private void LoadFaculty()
        {
            facultyList = AllocateRoomToFacultyBL.GetFacultyList();
            facultyComboBox.DataSource = facultyList;
            facultyComboBox.DisplayMember = "Name";
            facultyComboBox.ValueMember = "FacultyId";
        }

        private void LoadRooms()
        {
            roomList = AllocateRoomToFacultyBL.GetRoomList();
            roomComboBox.DataSource = roomList;
            roomComboBox.DisplayMember = "RoomName";
            roomComboBox.ValueMember = "RoomId";
        }

        private void LoadSemesters()
        {
            semesterList = AllocateRoomToFacultyBL.GetSemesterList();
            semesterComboBox.DataSource = semesterList;
            semesterComboBox.DisplayMember = "SemesterName";
            semesterComboBox.ValueMember = "SemesterId";
        }
             
        private void allocateButton_Click_1(object sender, EventArgs e)
        {
            if (facultyComboBox.SelectedItem == null || roomComboBox.SelectedItem == null || semesterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty, room, and semester.");
                return;
            }

            int facultyId = (int)facultyComboBox.SelectedValue;
            int roomId = (int)roomComboBox.SelectedValue;
            int semesterId = (int)semesterComboBox.SelectedValue;
            int reservedHours = (int)reservedHoursNumericUpDown.Value;

            if (AllocateRoomToFacultyBL.AllocateRoom(facultyId, roomId, semesterId, reservedHours))
            {
                MessageBox.Show("Room allocated to faculty successfully!");
            }
            else
            {
                MessageBox.Show("Failed to allocate room to faculty.");
            }

        }

        private void backLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyRoomManagement mainMenu = new FacultyRoomManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();

        }
    }
}
