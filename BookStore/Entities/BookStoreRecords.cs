namespace BookStore.Entities
{
    // =============================
    // Core DB Records (per tables)
    // =============================

    // ---- authors ----
    public record Author(string AuId // varchar(11) PK
        , string AuLName // varchar(40) NOT NULL
        , string AuFName // varchar(20) NOT NULL
        , string Phone // char(12) NOT NULL
        , string? Address // varchar(40) NULL
        , string? City // varchar(20) NULL
        , string? State // char(2) NULL
        , string? Zip // char(5) NULL
        , bool Contract); // bit NOT NULL

    // ---- titles ----
    public record Title(string TitleId // varchar(6) PK
        , string TitleName // varchar(80) NOT NULL
        , string Type // char(12) NOT NULL
        , string? PubId // char(4) FK NULL
        , decimal? Price // money NULL
        , decimal? Advance // money NULL
        , int? Royalty // int NULL
        , int? YtdSales // int NULL
        , string? Notes // varchar(200) NULL
        , DateTime PubDate); // datetime NOT NULL

    // ---- titleauthor (bridge) ----
    public record TitleAuthor(string AuId // varchar(11) PK/FK
        , string TitleId // varchar(6) PK/FK
        , byte? AuOrd // tinyint NULL
        , int? RoyaltyPer); // int NULL

    // ---- publishers ----
    public record Publisher(string PubId // char(4) PK
        , string? PubName // varchar(40) NULL
        , string? City // varchar(20) NULL
        , string? State // char(2) NULL
        , string? Country); // varchar(30) NULL

    // ---- pub_info ----
    public record PubInfo(string PubId // char(4) PK/FK
        , byte[]? Logo // image NULL
        , string? PrInfo); // text NULL

    // ---- stores ----
    public record Store(string StorId // char(4) PK
        , string? StorName // varchar(40) NULL
        , string? StorAddress // varchar(40) NULL
        , string? City // varchar(20) NULL
        , string? State // char(2) NULL
        , string? Zip ); // char(5) NULL

    // ---- discounts ----
    public record Discount(string DiscountType // varchar(40) NOT NULL
        , string? StorId // char(4) FK NULL
        , short? LowQty // smallint NULL
        , short? HighQty // smallint NULL
        , decimal DiscountPct); // decimal(4,2) NOT NULL

    // ---- jobs ----
    public record Job(short JobId // smallint PK
        , string JobDesc // varchar(50) NOT NULL
        , byte MinLvl // tinyint NOT NULL
        , byte MaxLvl); // tinyint NOT NULL

    // ---- employee ----
    public record Employee(string EmpId // char(9) PK
        , string FName // varchar(20) NOT NULL
        , string? MInit // char(1) NULL
        , string LName // varchar(30) NOT NULL
        , short JobId // smallint FK NOT NULL
        , byte? JobLvl // tinyint NOT NULL
        , string PubId // char(4) FK NOT NULL
        , DateTime HireDate); // datetime NOT NULL

    // ---- roysched ----
    public record RoySched(string TitleId // varchar(6) PK/FK
        , int? LoRange // int NULL
        , int? HiRange // int NULL
        , int? Royalty); // int NULL

    // ---- sales ----
    public record Sales(string StorId // char(4) PK/FK
        , long OrdNum // bigint PK
        , DateTime OrdDate // datetime NOT NULL
        , short Qty // smallint NOT NULL
        , string PayTerms // varchar(12) NOT NULL
        , string TitleId); // varchar(6) PK/FK

    // ==========================================
    // Stored Procedure Result Records (DTOs)
    // ==========================================

    // get*Ids(): id, info
    public record IdInfo(string Id
        , string? Info); // generic descriptor

    // getTitlesByPartialTitle(): title_id, title, price, au_name, pub_name, pubdate
    public record TitleSummary(string TitleId
        , string Title
        , decimal? Price
        , string AuName
        , string? PubName
        , DateTime PubDate);

    // getSalesByTimeRange(): ord_num, ord_date, title_id, title, qty, total_value
    public record SalesSummaryRow(long OrdNum
        , DateTime OrdDate
        , string TitleId
        , string Title
        , short Qty
        , decimal? TotalValue);

    public record OrderItem(string TitleId
        , string Title
        , decimal? Price
        , short Qty
        , string AuName
        , string? PubName
        , DateTime PubDate);
}
