using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Monthly_WorkLogData
    {
        public int EMPID { get; set; }
        public Nullable<System.DateTime> ForDate { get; set; }
        public Nullable<decimal> WORKHOURS { get; set; }
    }
}
