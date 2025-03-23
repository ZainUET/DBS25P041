namespace DB_Mid_Project.BL
{
    public class ScheduleCourseForFacultyBL
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ScheduleCourseForFacultyBL(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
