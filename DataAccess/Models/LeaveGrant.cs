using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveGrant
    {
        public int RequestID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<int> LeaveCategoryId { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public string TimeTypeFrom { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string TimeTypeTo { get; set; }
        public string NoOfDays { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string Cause { get; set; }
        public string isCompoff { get; set; }
    }
}
