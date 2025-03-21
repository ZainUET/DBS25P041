using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RemoveProjectDL
    {
        public static List<KeyValuePair<int, string>> GetProjects()
        {
            List<KeyValuePair<int, string>> projectList = new List<KeyValuePair<int, string>>();

            try
            {
                string query = "SELECT project_id, title FROM projects";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        projectList.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("project_id"),
                            reader.GetString("title")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading projects: " + ex.Message);
            }

            return projectList;
        }

        public static int RemoveProject(int projectId)
        {
            try
            {
                string query = $"DELETE FROM projects WHERE project_id = {projectId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing project: " + ex.Message);
            }
        }
    }
}
