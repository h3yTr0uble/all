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
    public class UserSqlDAO : IUserDAO
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public void Add(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("AddUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthDate", user.Birthdate);
                command.Parameters.AddWithValue("@age", user.Age);

                DataTable rewardsTable = new DataTable();
                rewardsTable.Columns.Add(new DataColumn("id", typeof(int)));
                foreach (var award in user.Awards)
                {
                    rewardsTable.Rows.Add(award.Id);
                }

                SqlParameter awardParameter = command.Parameters.AddWithValue("@awardIds", rewardsTable);
                awardParameter.SqlDbType = SqlDbType.Structured;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetList()
        {
            List<User> users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT Id, FirstName, LastName, Birthdate FROM Users");
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    DateTime birthdate = (DateTime)reader["Birthdate"];

                    users.Add(new User(id, firstName, lastName, birthdate));
                }
                reader.Close();
                var cmd = new SqlCommand("GetUserAwards");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@userId", 0);
                for (int i = 0; i < users.Count; i++)
                {
                    cmd.Parameters["@userId"].Value = users[i].Id;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string title = (string)reader["title"];
                        string description = (string)reader["description"];
                        users[i].AddAward(new Award(id, title, description));
                    }
                    reader.Close();
                }
                return users;
                
            }
        }

        public void Remove(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemoveUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@userId", user.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Remove(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemoveUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@userId", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public void Edit(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("UpdateUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@userId", user.Id);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthDate", user.Birthdate);
                command.Parameters.AddWithValue("@age", user.Age);

                DataTable rewardsTable = new DataTable();
                rewardsTable.Columns.Add(new DataColumn("id", typeof(int)));
                foreach (var award in user.Awards)
                {
                    rewardsTable.Rows.Add(award.Id);
                }

                SqlParameter awardParameter = command.Parameters.AddWithValue("@awardIds", rewardsTable);
                awardParameter.SqlDbType = SqlDbType.Structured;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
