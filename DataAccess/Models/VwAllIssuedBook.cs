using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VwAllIssuedBook
    {
        public decimal ID { get; set; }
        public decimal BookID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<int> Emp_ID { get; set; }
        public string UserName { get; set; }
        public string EmployeeName { get; set; }
        public string Purpose { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string IsLost { get; set; }
    }
}
