using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entities;

namespace Department.DAL
{
    public class AwardSqlDAO : IAwardDAO
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public void Add(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("AddAward");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@title", award.Title);
                command.Parameters.AddWithValue("@description", award.Description);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("UpdateAward");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", award.Id);
                command.Parameters.AddWithValue("@title", award.Title);
                command.Parameters.AddWithValue("@description", award.Description);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Award> GetList()
        {
            List<Award> awards = new List<Award>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT Id, Title, Description FROM Awards");
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["title"];
                    string description = (string)reader["description"];

                    awards.Add(new Award(id, title, description));
                }
                reader.Close();
                return awards;
            }
        }

        public void Remove(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("DeleteAward");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@Id", award.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
