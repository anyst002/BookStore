using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BookStore
{
    public static class PublisherRepository
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;

        public static void InsertPublisher(Publisher publisher)
        {
            if (publisher == null) throw new ArgumentNullException(nameof(publisher));

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("insertPublisher", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pub_id", publisher.PubId);
                cmd.Parameters.AddWithValue("@pub_name", (object?)publisher.PubName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@city", (object?)publisher.City ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@state", (object?)publisher.State ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@country", (object?)publisher.Country ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
