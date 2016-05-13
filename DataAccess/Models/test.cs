using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class test
    {
        public int EMPID { get; set; }
        public Nullable<System.DateTime> ForDate { get; set; }
        public Nullable<decimal> WORKHOURS { get; set; }
        public Nullable<int> ProjId { get; set; }
    }
}
