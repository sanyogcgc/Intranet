using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class targetunit
    {
        public int id { get; set; }
        public Nullable<int> unitid { get; set; }
        public Nullable<decimal> teamcost { get; set; }
        public Nullable<int> targetmonth { get; set; }
        public Nullable<int> targetyear { get; set; }
    }
}
