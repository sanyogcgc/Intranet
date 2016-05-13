using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vw_LostBooks
    {
        public Nullable<decimal> ID { get; set; }
        public decimal BookID { get; set; }
        public Nullable<int> Emp_ID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> DateOfLost { get; set; }
    }
}
