using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    public static class AssignProjectToFacultyBL
    {
        public static List<KeyValuePair<int, string>> GetFaculty()
        {
            return AssignProjectToFacultyDL.GetFaculty();
        }

        public static List<KeyValuePair<int, string>> GetProjects()
        {
            return AssignProjectToFacultyDL.GetProjects();
        }

        public static List<KeyValuePair<int, string>> GetSemesters()
        {
            return AssignProjectToFacultyDL.GetSemesters();
        }

        public static bool AssignProject(int facultyId, int projectId, int semesterId, int supervisionHours)
        {
            return AssignProjectToFacultyDL.AssignProject(facultyId, projectId, semesterId, supervisionHours);
        }
    }
}
