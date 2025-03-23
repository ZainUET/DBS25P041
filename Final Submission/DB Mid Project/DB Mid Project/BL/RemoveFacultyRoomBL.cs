using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    public static class RemoveFacultyRoomBL
    {
        public static List<FacultyRoomAllocation> GetFacultyRoomAllocations()
        {
            return RemoveFacultyRoomDL.GetFacultyRoomAllocations();
        }

        public static bool RemoveFacultyRoomAllocation(int allocationId)
        {
            return RemoveFacultyRoomDL.RemoveFacultyRoomAllocation(allocationId);
        }
    }
}
