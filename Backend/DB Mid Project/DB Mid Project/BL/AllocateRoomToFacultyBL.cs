using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    public static class AllocateRoomToFacultyBL
    {
        public static List<Faculty> GetFacultyList()
        {
            return AllocateRoomToFacultyDL.GetFaculty();
        }

        public static List<Room> GetRoomList()
        {
            return AllocateRoomToFacultyDL.GetRooms();
        }

        public static List<Semester> GetSemesterList()
        {
            return AllocateRoomToFacultyDL.GetSemesters();
        }

        public static bool AllocateRoom(int facultyId, int roomId, int semesterId, int reservedHours)
        {
            return AllocateRoomToFacultyDL.AllocateRoom(facultyId, roomId, semesterId, reservedHours);
        }
    }
}
