using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ReceiptUnit
    {
        public int ReceiptID { get; set; }
        public Nullable<int> MilID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> TDS { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
