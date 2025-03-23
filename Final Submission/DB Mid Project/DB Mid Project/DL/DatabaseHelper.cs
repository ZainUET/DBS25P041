using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class DatabaseHelper
    {
        private string serverName = "127.0.0.1";
        private string port = "3306";
        private string databaseName = "midprojectdb";
        private string databaseUser = "root";
        private string databasePassword = "zain.8773";
        private DatabaseHelper() { }
        private static DatabaseHelper? _instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }
        public MySqlConnection getConnection()
        {
            string connectionString = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Required;";
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public MySqlDataReader getData(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, getConnection()))
                {
                    return command.ExecuteReader();
                }
            }
        }

        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader); // Load data into DataTable
                    }
                }
            }
            return dt;
        }
        public int Update(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, getConnection()))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

        internal object Query(string query)
        {
            throw new NotImplementedException();
        }

    }
}
