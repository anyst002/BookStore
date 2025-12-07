using static BookStore.Data.Repository;
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

        public static decimal CalculateSalesSummaryTotal(List<SalesSummaryRow> list)
        {
            decimal subtotal = 0.00m;
            foreach (SalesSummaryRow entry in list)
            {
                 subtotal += entry.TotalValue ?? 0;
            }
            return subtotal;
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

            InsertAuthor(author);
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

            InsertEmployee(emp);
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

            InsertPublisher(publisher);
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

            InsertStore(store);
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

            InsertTitle(title);
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

            InsertTitleAuthor(titleAuthor);
        }

        public static List<SalesSummaryRow> GetReports(DateTime start, DateTime end, string storeId)
        {
            return GetSalesByTimeRange(start, end, storeId);
        }

        public static List<IdInfo> SelectAuthorIds() //rename
        {
            return GetAuthorIds();
        }

        public static List<IdInfo> SelectJobIds()
        {
            return GetJobIds();
        }

        public static List<IdInfo> SelectPublisherIds()
        {
            return GetPublisherIds();
        }

        public static List<IdInfo> SelectStoreIds()
        {
            return GetStoreIds();
        }
    }
}
