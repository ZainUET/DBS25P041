using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class SemesterDL
    {
        public static int AddSemester(string term, int year)
        {
            string query = $"INSERT INTO semesters (term, year) VALUES ('{term}', {year})";
            return DatabaseHelper.Instance.Update(query);
        }
    }
}
