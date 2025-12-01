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
        public void InsertTitle(Title title)
{
    SqlCommand command = new SqlCommand(
        @"INSERT INTO titles
    (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate)
  VALUES
    (@id, @name, @type, @pubid, @price, @advance, @royalty, @ytd, @notes, @date)");

    ExecuteNonQuery(command, () =>
    {
        command.Parameters.AddWithValue("@id", title.TitleId);
        command.Parameters.AddWithValue("@name", title.TitleName);
        command.Parameters.AddWithValue("@type", title.Type);
        command.Parameters.AddWithValue("@pubid", (object?)title.PubId ?? DBNull.Value);
        command.Parameters.AddWithValue("@price", (object?)title.Price ?? DBNull.Value);
        command.Parameters.AddWithValue("@advance", (object?)title.Advance ?? DBNull.Value);
        command.Parameters.AddWithValue("@royalty", (object?)title.Royalty ?? DBNull.Value);
        command.Parameters.AddWithValue("@ytd", (object?)title.YtdSales ?? DBNull.Value);
        command.Parameters.AddWithValue("@notes", (object?)title.Notes ?? DBNull.Value);
        command.Parameters.AddWithValue("@date", title.PubDate);
    });
}



public void InsertTitleAuthor(TitleAuthor entry)
{
    SqlCommand command = new SqlCommand(
        @"INSERT INTO titleauthor
    (au_id, title_id, au_ord, royaltyper)
  VALUES
    (@aid, @tid, @ord, @roy)");

    ExecuteNonQuery(command, () =>
    {
        command.Parameters.AddWithValue("@aid", entry.AuId);
        command.Parameters.AddWithValue("@tid", entry.TitleId);
        command.Parameters.AddWithValue("@ord", (object?)entry.AuOrd ?? DBNull.Value);
        command.Parameters.AddWithValue("@roy", (object?)entry.RoyaltyPer ?? DBNull.Value);
    });
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
            string query = "EXEC getAuthorIds";
            return GetIdInfos(query);
        }

        public List<IdInfo> GetJobIds()
        {
            string query = "EXEC getJobIds";
            return GetIdInfos(query);
        }

        public List<IdInfo> GetPublisherIds()
        {
            string query = "EXEC getPublisherIds";
            return GetIdInfos(query);
        }

        public List<IdInfo> GetStoreIds()
        {
            string query = "EXEC getStoreIds";
            return GetIdInfos(query);
        }

        private List<IdInfo> GetIdInfos(string query)
        {
            using (SqlConnection connection = new(connectionString)) //probably should be moved up to parent class somehow
            {
                SqlCommand command = new(query);
                command.Connection = connection;

                List<IdInfo> list = new List<IdInfo>();

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string? info = (reader[1] is null) ? null : Convert.ToString(reader[1]);

                        IdInfo result = new IdInfo(Convert.ToString(reader[0])!
                            , info);

                        list.Add(result);
                    }

                    return list;
                }
            }
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
                        decimal? price = (reader[2] is null) ? null : Decimal.Round(Convert.ToDecimal(reader[2]), 2);
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
