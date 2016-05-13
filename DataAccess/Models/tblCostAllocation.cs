using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblCostAllocation
    {
        public string PIN { get; set; }
        public Nullable<double> ExpenseAmount { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
        public int costallocationid { get; set; }
    }
}
