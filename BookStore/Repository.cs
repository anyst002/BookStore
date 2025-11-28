using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStore
{
    public class Repository
    {
        protected string connectionString;

        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;           
        }

        protected void ExecuteNonQuery(SqlCommand command, Action query)
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
    public class MaintenanceRepository : Repository
    {
        public void InsertTitle()
        {

        }

        public void InsertTitleAuthor()
        {

        }

        public void InsertAuthor()
        {

        }

        public void InsertPublisher()
        {

        }

        public void InsertStore()
        {

        }

        public void InsertEmployee()
        {

        }

        public List<IdInfo> GetAuthorIds()
        {
            List<IdInfo> list = new List<IdInfo>(); //TODO remove later, temp list
            IdInfo info1 = new IdInfo("007", "author test");
            IdInfo info2 = new IdInfo("008", "author test 2");
            list.Add(info1);
            list.Add(info2);
            return list;

            //using SqlDataReader reader = command.ExecuteReader();

            //reader.Read();
            //MessageBox.Show(reader.GetString(0));
            //reader.Close();
        }

        public List<IdInfo> GetJobIds()
        {
            List<IdInfo> list = new List<IdInfo>(); //TODO remove later, temp list
            IdInfo info1 = new IdInfo("001", "job test");
            IdInfo info2 = new IdInfo("002", "job test 2");
            list.Add(info1);
            list.Add(info2);
            return list;
        }

        public List<IdInfo> GetPublisherIds()
        {
            List<IdInfo> list = new List<IdInfo>(); //TODO remove later, temp list
            IdInfo info1 = new IdInfo("003", "pub test");
            IdInfo info2 = new IdInfo("004", "pub test 2");
            list.Add(info1);
            list.Add(info2);
            return list;
        }

        public List<IdInfo> GetStoreIds()
        {
            List<IdInfo> list = new List<IdInfo>(); //TODO remove later, temp list
            IdInfo info1 = new IdInfo("005", "store test");
            IdInfo info2 = new IdInfo("006", "store test 2");
            list.Add(info1);
            list.Add(info2);
            return list;
        }

        public static string SelectId(List<IdInfo> list)
        {
            frmSelectId selectForm = new frmSelectId(list);
            selectForm.ShowDialog();
            IdInfo? item = selectForm.selected;

            if (item is not null) return item.Id;
            else return "";
        }
    }
    public class OrderRepository : Repository
    {
        public void InsertSale(Sales sale)
        {
            SqlCommand command = new($"EXEC insertSales @stor_id @ord_num @ord_date @qty @payterms @title_id");
            ExecuteNonQuery(command, () => 
            {
                command.Parameters.AddWithValue("@stor_id", sale.StorId);
                command.Parameters.AddWithValue("@ord_num", sale.OrdNum);
                command.Parameters.AddWithValue("@ord_date", sale.OrdDate);
                command.Parameters.AddWithValue("@qty", sale.Qty);
                command.Parameters.AddWithValue("@payterms", sale.PayTerms);
                command.Parameters.AddWithValue("@title_id", sale.TitleId);
            });
        }

        public long GetOrderNum(string storeId)
        {
            using (SqlConnection connection = new(connectionString)) //probably should be moved up to parent class somehow
            {
                SqlCommand command = new($"EXEC getNextOrderNum @store_id, @next_num OUTPUT");
                command.Parameters.AddWithValue("@store_id", storeId);
                command.Parameters.AddWithValue("@next_num", 0);
                command.Connection = connection;

                connection.Open();
                long ordNum = Convert.ToInt64(command.ExecuteScalar());
                MessageBox.Show($"ordNum={ordNum}");
                return ordNum;
            }
        }

        public List<TitleSearchResult> GetTitlesByPartialTitle(string partialTitle)
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new($"EXEC getTitlesByPartialTitle @partial_title");
                command.Parameters.AddWithValue("@partial_title", partialTitle);
                command.Connection = connection;

                List<TitleSearchResult> list = new List<TitleSearchResult>();

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal? price = (reader[2] is null) ? null : Convert.ToDecimal(reader[2]);
                        string? pubName = (reader[4] is null) ? null : Convert.ToString(reader[4]);

                        TitleSearchResult result = new TitleSearchResult(Convert.ToString(reader[0])!
                            , Convert.ToString(reader[1])!
                            , price
                            , Convert.ToString(reader[3])!
                            , pubName
                            , Convert.ToDateTime(reader[5]));

                        list.Add(result);
                    }

                    return list;
                }
            }
        }
    }
    public class ReportRepository : Repository
    {
        private string storeId;

        public ReportRepository(string storeId)
        {
            this.storeId = storeId;
            //verify this doesn't overwrite parent constructor
        }

        public List<SalesSummaryRow> GetSalesByTimeRange()
        {
            return new List<SalesSummaryRow>();
        }
    }
}
