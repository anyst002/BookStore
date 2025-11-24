using System;

namespace BookStore
{
    // =============================
    // Core DB Records (per tables)
    // =============================

    // ---- authors ----
    public record Author
    {
        public string AuId { get; init; }          // varchar(11) PK
        public string AuLName { get; init; }       // varchar(40) NOT NULL
        public string AuFName { get; init; }       // varchar(20) NOT NULL
        public string Phone { get; init; }         // char(12) NOT NULL

        public string Address { get; init; }       // varchar(40) NULL
        public string City { get; init; }          // varchar(20) NULL
        public string State { get; init; }         // char(2) NULL
        public string Zip { get; init; }           // char(5) NULL

        public bool Contract { get; init; }        // bit NOT NULL
    }

    // ---- titles ----
    public record Title
    {
        public string TitleId { get; init; }       // varchar(6) PK
        public string TitleName { get; init; }     // varchar(80) NOT NULL
        public string Type { get; init; }          // char(12) NOT NULL

        public string PubId { get; init; }         // char(4) FK NULL

        public decimal? Price { get; init; }       // money NULL
        public decimal? Advance { get; init; }     // money NULL
        public int? Royalty { get; init; }         // int NULL
        public int? YtdSales { get; init; }        // int NULL
        public string Notes { get; init; }         // varchar(200) NULL

        public DateTime PubDate { get; init; }     // datetime NOT NULL
    }

    // ---- titleauthor (bridge) ----
    public record TitleAuthor
    {
        public string AuId { get; init; }          // varchar(11) PK/FK
        public string TitleId { get; init; }       // varchar(6) PK/FK

        public byte? AuOrd { get; init; }          // tinyint NULL
        public int? RoyaltyPer { get; init; }      // int NULL
    }

    // ---- publishers ----
    public record Publisher
    {
        public string PubId { get; init; }         // char(4) PK
        public string PubName { get; init; }       // varchar(40) NULL
        public string City { get; init; }          // varchar(20) NULL
        public string State { get; init; }         // char(2) NULL
        public string Country { get; init; }       // varchar(30) NULL
    }

    // ---- pub_info ----
    public record PubInfo
    {
        public string PubId { get; init; }         // char(4) PK/FK
        public byte[] Logo { get; init; }          // image NULL
        public string PrInfo { get; init; }        // text NULL
    }

    // ---- stores ----
    public record Store
    {
        public string StorId { get; init; }        // char(4) PK
        public string StorName { get; init; }      // varchar(40) NULL
        public string StorAddress { get; init; }   // varchar(40) NULL
        public string City { get; init; }          // varchar(20) NULL
        public string State { get; init; }         // char(2) NULL
        public string Zip { get; init; }           // char(5) NULL
    }

    // ---- discounts ----
    public record Discount
    {
        public string DiscountType { get; init; }  // varchar(40) NOT NULL
        public string StorId { get; init; }        // char(4) FK NULL
        public short? LowQty { get; init; }        // smallint NULL
        public short? HighQty { get; init; }       // smallint NULL
        public decimal DiscountPct { get; init; }  // decimal(4,2) NOT NULL
    }

    // ---- jobs ----
    public record Job
    {
        public short JobId { get; init; }          // smallint PK
        public string JobDesc { get; init; }       // varchar(50) NOT NULL
        public byte MinLvl { get; init; }          // tinyint NOT NULL
        public byte MaxLvl { get; init; }          // tinyint NOT NULL
    }

    // ---- employee ----
    public record Employee
    {
        public string EmpId { get; init; }         // char(9) PK
        public string FName { get; init; }         // varchar(20) NOT NULL
        public char? MInit { get; init; }          // char(1) NULL
        public string LName { get; init; }         // varchar(30) NOT NULL

        public short JobId { get; init; }          // smallint FK NOT NULL
        public byte JobLvl { get; init; }          // tinyint NOT NULL

        public string PubId { get; init; }         // char(4) FK NOT NULL
        public DateTime HireDate { get; init; }    // datetime NOT NULL
    }

    // ---- roysched ----
    public record RoySched
    {
        public string TitleId { get; init; }       // varchar(6) PK/FK
        public int? LoRange { get; init; }         // int NULL
        public int? HiRange { get; init; }         // int NULL
        public int? Royalty { get; init; }         // int NULL
    }

    // ---- sales ----
    public record Sales
    {
        public string StorId { get; init; }        // char(4) PK/FK
        public long OrdNum { get; init; }          // bigint PK
        public DateTime OrdDate { get; init; }     // datetime NOT NULL
        public short Qty { get; init; }            // smallint NOT NULL
        public string PayTerms { get; init; }      // varchar(12) NOT NULL
        public string TitleId { get; init; }       // varchar(6) PK/FK
    }

    // ==========================================
    // Stored Procedure Result Records (DTOs)
    // ==========================================

    // getAuthorIds(): au_id, au_name
    public record AuthorIdInfo
    {
        public string AuId { get; init; }
        public string AuName { get; init; }        // concatenated name
    }

    // getJobIds(): job_id, job_desc
    public record JobIdInfo
    {
        public short JobId { get; init; }
        public string JobDesc { get; init; }
    }

    // getPublisherIds(): pub_id, pub_name
    public record PublisherIdInfo
    {
        public string PubId { get; init; }
        public string PubName { get; init; }
    }

    // getStoreIds(): stor_id, stor_name
    public record StoreIdInfo
    {
        public string StorId { get; init; }
        public string StorName { get; init; }
    }

    // getTitlesByPartialTitle(): title_id, title, price, au_name, pub_name, pubdate
    public record TitleSearchResult
    {
        public string TitleId { get; init; }
        public string Title { get; init; }
        public decimal? Price { get; init; }
        public string AuName { get; init; }
        public string PubName { get; init; }
        public DateTime PubDate { get; init; }
    }

    // getSalesByTimeRange(): ord_num, ord_date, title_id, title, qty, total_value
    public record SalesSummaryRow
    {
        public long OrdNum { get; init; }
        public DateTime OrdDate { get; init; }
        public string TitleId { get; init; }
        public string Title { get; init; }
        public short Qty { get; init; }
        public decimal TotalValue { get; init; }
    }
}
