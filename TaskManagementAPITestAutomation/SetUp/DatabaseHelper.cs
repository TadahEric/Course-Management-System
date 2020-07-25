using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TaskManagementAPITestAutomation.Model;

namespace TaskManagementAPITestAutomation.SetUp
{
    public class DatabaseHelper
    {
        string connectionString = EnvironmentData.connectionString;        

        public void ClearOrPopulateATable(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<ProjectModel> RetrieveDataFromATable(string query)
        {
            List<ProjectModel> records = new List<ProjectModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProjectModel record = new ProjectModel();
                        record.Name = reader["Name"].ToString();
                        records.Add(record);
                    }
                    connection.Close();
                }                
            }
            return records;
        }

        public string SelectNameFromProjectTable(string query)
        {
            string name = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    name = (string)command.ExecuteScalar();
                }
            }
            return name;
        }

        public int SelectIdFromProjectTable(string query)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    id = (Int32)command.ExecuteScalar();
                }
            }
            return id;
        }
    }
}
