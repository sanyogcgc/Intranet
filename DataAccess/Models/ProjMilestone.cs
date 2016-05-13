using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjMilestone
    {
        public int MilID { get; set; }
        public Nullable<int> PID { get; set; }
        public string MilName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
