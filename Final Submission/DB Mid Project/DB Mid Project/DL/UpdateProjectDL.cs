using System;
using System.Collections.Generic;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class UpdateProjectDL
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

        public static DataRow GetProjectDetails(int projectId)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT title, description FROM projects WHERE project_id = {projectId}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading project details: " + ex.Message);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int UpdateProject(int projectId, string title, string description)
        {
            try
            {
                string query = $"UPDATE projects SET title = '{title}', description = '{description}' WHERE project_id = {projectId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating project: " + ex.Message);
            }
        }
    }
}
