using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
