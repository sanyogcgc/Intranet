using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vw_LostBooksAll
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
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> DateOfLost { get; set; }
        public Nullable<int> Emp_ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string category { get; set; }
    }
}
