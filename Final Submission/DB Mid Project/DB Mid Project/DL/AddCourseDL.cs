using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    internal class AddCourseDL
    {

        public class CourseDL
        {
            public static int AddCourse(string courseName, string courseType, int creditHours, int contactHours)
            {
                string query = "INSERT INTO courses (course_name, course_type, credit_hours, contact_hours) " +
                               "VALUES (@courseName, @courseType, @creditHours, @contactHours)";

                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@courseName", courseName);
                        cmd.Parameters.AddWithValue("@courseType", courseType);
                        cmd.Parameters.AddWithValue("@creditHours", creditHours);
                        cmd.Parameters.AddWithValue("@contactHours", contactHours);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }

}
