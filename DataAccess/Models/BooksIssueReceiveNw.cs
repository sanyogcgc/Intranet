using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BooksIssueReceiveNw
    {
        public decimal ID { get; set; }
        public decimal BookID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<int> Emp_ID { get; set; }
        public string Purpose { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public string BookCondition { get; set; }
        public string IsLost { get; set; }
        public Nullable<System.DateTime> DateOfLost { get; set; }
    }
}
