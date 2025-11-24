using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Repository
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public Repository()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BookStore"].ConnectionString;
            connection = new(connectionString);
            command = new("", connection);
        }

        private void Dispose()
        {
            connection.Dispose();
            command.Dispose();
        }

        ~Repository()
        {
            Dispose();
        }
    }
    public class MaintenanceRepository : Repository
    {
        public void InsertTitle() //TODO alter later
        {
            connection.Open();
            command.CommandText = $"SELECT * FROM titles";
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            MessageBox.Show(reader.GetString(0));
            reader.Close();
            connection.Close();
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

        public static void SelectId(List<IdInfo> list, TextBox textbox) //TODO this should be moved out to decouple
        {
            frmSelectId selectForm = new frmSelectId(list);
            selectForm.ShowDialog();
            IdInfo? item = selectForm.selected;

            if (item is not null) textbox.Text = item.Id;
        }
    }
    public class OrderRepository : Repository
    {
        public void InsertSales()
        {

        }

        public long GetOrderNum()
        {
            return 1;
        }

        public List<TitleSearchResult> GetTitlesByPartialTitle()
        {
            return new List<TitleSearchResult>();
        }
    }
    public class ReportRepository : Repository
    {
        public List<SalesSummaryRow> GetSalesByTimeRange()
        {
            return new List<SalesSummaryRow>();
        }
    }
}
