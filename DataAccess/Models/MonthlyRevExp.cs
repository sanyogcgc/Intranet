using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MonthlyRevExp
    {
        public int ID { get; set; }
        public Nullable<int> ExpYear { get; set; }
        public Nullable<int> ExpMonth { get; set; }
        public Nullable<decimal> USBase { get; set; }
        public Nullable<decimal> Expanses { get; set; }
        public Nullable<decimal> INRBase { get; set; }
        public Nullable<decimal> Revenue { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
