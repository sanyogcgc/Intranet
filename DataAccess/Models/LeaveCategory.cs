using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveCategory
    {
        public int LeaveCategoryId { get; set; }
        public string Leavecategory1 { get; set; }
        public string Description { get; set; }
        public Nullable<int> LeaveDays3 { get; set; }
        public string IsCarryForward { get; set; }
        public string FinYesrID { get; set; }
        public Nullable<int> LeaveDays6 { get; set; }
        public string AfterOneYear { get; set; }
        public string Acts { get; set; }
    }
}
