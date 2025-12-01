using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BookStore
{
    public static class StoreRepository
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;

        public static void InsertStore(Store store)
        {
            if (store == null) throw new ArgumentNullException(nameof(store));

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("insertStore", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@stor_id", store.StorId);
                cmd.Parameters.AddWithValue("@stor_name", (object?)store.StorName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@stor_address", (object?)store.StorAddress ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@city", (object?)store.City ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@state", (object?)store.State ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@zip", (object?)store.Zip ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
