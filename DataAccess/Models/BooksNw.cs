using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BooksNw
    {
        public decimal BookID { get; set; }
        public Nullable<decimal> CategoryID { get; set; }
        public Nullable<System.DateTime> DateofPurchase { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string IsAvailable { get; set; }
        public string BookCode { get; set; }
        public string Subject { get; set; }
        public string Cost { get; set; }
    }
}
