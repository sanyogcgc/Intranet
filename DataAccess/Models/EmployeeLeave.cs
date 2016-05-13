using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class EmployeeLeave
    {
        public int EmployeeID { get; set; }
        public Nullable<int> FinYearID { get; set; }
        public Nullable<int> LeaveCategoryid { get; set; }
        public Nullable<float> TotalLeave { get; set; }
        public string ApplicableFrom { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
    }
}
