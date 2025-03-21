using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RemoveSemesterDL
    {
        public static List<KeyValuePair<int, string>> GetSemesters()
        {
            List<KeyValuePair<int, string>> semesterList = new List<KeyValuePair<int, string>>();

            try
            {
                string query = "SELECT semester_id, CONCAT(term, ' ', year) AS semester FROM semesters";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        semesterList.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("semester_id"),
                            reader.GetString("semester")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading semesters: " + ex.Message);
            }

            return semesterList;
        }

        public static int RemoveSemester(int semesterId)
        {
            try
            {
                string query = $"DELETE FROM semesters WHERE semester_id = {semesterId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing semester: " + ex.Message);
            }
        }
    }
}
