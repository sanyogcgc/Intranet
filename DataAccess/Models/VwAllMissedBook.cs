using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VwAllMissedBook
    {
        public decimal BookID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string IsLost { get; set; }
        public Nullable<System.DateTime> DateOfLost { get; set; }
        public Nullable<int> Emp_ID { get; set; }
    }
}
