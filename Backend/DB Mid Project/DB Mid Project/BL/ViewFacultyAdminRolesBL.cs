namespace DB_Mid_Project.BL
{
    public class ViewFacultyAdminRolesBL
    {
        public int AdminRoleId { get; set; }
        public string Faculty { get; set; }
        public string Role { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }

        public ViewFacultyAdminRolesBL(int adminRoleId, string faculty, string role, string term, int year)
        {
            AdminRoleId = adminRoleId;
            Faculty = faculty;
            Role = role;
            Term = term;
            Year = year;
        }
    }
}
