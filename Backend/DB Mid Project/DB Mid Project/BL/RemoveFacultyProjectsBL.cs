using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    public static class RemoveFacultyProjectsBL
    {
        public static List<FacultyProject> GetFacultyProjects()
        {
            return RemoveFacultyProjectsDL.GetFacultyProjects();
        }

        public static bool RemoveFacultyProject(int facultyProjectId)
        {
            return RemoveFacultyProjectsDL.RemoveFacultyProject(facultyProjectId);
        }
    }
}
