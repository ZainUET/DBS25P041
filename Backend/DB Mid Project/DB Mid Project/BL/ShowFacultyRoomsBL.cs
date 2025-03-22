using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    public static class ShowFacultyRoomsBL
    {
        public static List<FacultyRoomAllocation> GetFacultyRoomAllocations()
        {
            return ShowFacultyRoomsDL.GetFacultyRoomAllocations();
        }
    }
}
