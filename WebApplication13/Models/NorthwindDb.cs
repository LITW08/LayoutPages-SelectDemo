using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Models
{
    public class NorthwindDb
    {
        private readonly string _connectionString;

        public NorthwindDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<string> GetCategoryNames()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Categories";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //string categoryName = (string) reader["CategoryName"];
                    string categoryName = reader.GetOrNull<string>("CategoryName");
                    DateTime?completedDate = reader.GetOrNull<DateTime?>("CompletedDate");
                }
            }
        }
    }
}
