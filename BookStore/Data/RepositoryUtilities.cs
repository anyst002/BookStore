using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace BookStore.Data
{
    internal static class RepositoryUtilities
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;

        public static void ExecuteNonQuery(SqlCommand command, Action query)
        {
            using (SqlConnection connection = new(connectionString))
            {
                query.Invoke();
                command.Connection = connection;
                
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Trace.Write(ex);
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }
    }
}
