using BookStore.Data;
using BookStore.Entities;

namespace BookStore.Business
{
    public static class BusinessManager
    {
        private static string? NullCheckString(string? str)
        {
            if (string.IsNullOrWhiteSpace(str)) return null;
            else return str;
        }

        private static int? NullCheckInt32(string? str)
        {
            if (string.IsNullOrWhiteSpace(str)) return null;
            else return Convert.ToInt32(str);
        }

        private static byte? NullCheckByte(string? str)
        {
            if (string.IsNullOrWhiteSpace(str)) return null;
            else return Convert.ToByte(str);
        }

        private static decimal? NullCheckDecimal(string? str)
        {
            if (string.IsNullOrWhiteSpace(str)) return null;
            else return Convert.ToDecimal(str);
        }

        public static void AddAuthor(string AuId
            , string AuLName
            , string AuFName
            , string Phone
            , string? Address
            , string? City
            , string? State
            , string? Zip
            , bool Contract)
        {
            Author author = new Author(AuId
                , AuLName
                , AuFName
                , Phone
                , NullCheckString(Address)
                , NullCheckString(City)
                , NullCheckString(State)
                , NullCheckString(Zip)
                , Contract);

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertAuthor(author);
        }

        public static void AddEmployee(string EmpId
            , string FName
            , string? MInit
            , string LName
            , short JobId
            , string? JobLvl
            , string PubId
            , DateTime HireDate)
        {
            Employee emp = new Employee(EmpId
                , FName
                , NullCheckString(MInit)
                , LName
                , JobId
                , NullCheckByte(JobLvl)
                , PubId
                , HireDate);

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertEmployee(emp);
        }

        public static void AddPublisher(string PubId
            , string? PubName
            , string? City
            , string? State
            , string? Country)
        {
            Publisher publisher = new Publisher(PubId
                , NullCheckString(PubName)
                , NullCheckString(City)
                , NullCheckString(State)
                , NullCheckString(Country));

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertPublisher(publisher);
        }

        public static void AddStore(string StorId
            , string? StorName
            , string? StorAddress
            , string? City
            , string? State
            , string? Zip)
        {
            Store store = new Store(StorId
                , NullCheckString(StorName)
                , NullCheckString(StorAddress)
                , NullCheckString(City)
                , NullCheckString(State)
                , NullCheckString(Zip));

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertStore(store);
        }

        public static void AddTitle(string TitleId
            , string TitleName
            , string Type
            , string? PubId
            , string? Price
            , string? Advance
            , string? Royalty
            , string? YtdSales
            , string? Notes
            , DateTime PubDate)
        {
            Title title = new Title(TitleId
                , TitleName
                , Type
                , NullCheckString(PubId)
                , NullCheckDecimal(Price)
                , NullCheckDecimal(Advance)
                , NullCheckInt32(Royalty)
                , NullCheckInt32(YtdSales)
                , NullCheckString(Notes)
                , PubDate);

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertTitle(title);
        }

        public static void AddTitleAuthor(string AuId
            , string TitleId
            , string? AuOrd
            , string? RoyaltyPer)
        {
            TitleAuthor titleAuthor = new TitleAuthor(AuId
                , TitleId
                , NullCheckByte(AuOrd)
                , NullCheckInt32(RoyaltyPer));

            MaintenanceRepository repo = new MaintenanceRepository();
            repo.InsertTitleAuthor(titleAuthor);
        }

        public static List<SalesSummaryRow> GetReports(DateTime start, DateTime end, string storeId)
        {
            ReportRepository repo = new ReportRepository(storeId);
            return repo.GetSalesByTimeRange(start, end);
        }
    }
}
