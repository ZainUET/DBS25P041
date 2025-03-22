using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    public static class ShowFacultyProjectsBL
    {
        public static List<FacultyProject> GetFacultyProjects()
        {
            return ShowFacultyProjectsDL.GetFacultyProjects();
        }
    }
}
