using System;
using System.Collections.Generic;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class UpdateSemesterDL
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

        public static DataRow GetSemesterDetails(int semesterId)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT term, year FROM semesters WHERE semester_id = {semesterId}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading semester details: " + ex.Message);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int UpdateSemester(int semesterId, string term, int year)
        {
            try
            {
                string query = $"UPDATE semesters SET term = '{term}', year = {year} WHERE semester_id = {semesterId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating semester: " + ex.Message);
            }
        }
    }
}
