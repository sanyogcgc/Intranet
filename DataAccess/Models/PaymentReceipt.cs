using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PaymentReceipt
    {
        public int ReceiptID { get; set; }
        public Nullable<int> MilID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> DateReceipt { get; set; }
        public Nullable<decimal> TDS { get; set; }
        public string Note { get; set; }
        public Nullable<int> PaymentType { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
