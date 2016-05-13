using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class bdtarget
    {
        public int id { get; set; }
        public Nullable<int> bdid { get; set; }
        public Nullable<decimal> targetreceipt { get; set; }
        public Nullable<int> targetmonth { get; set; }
        public Nullable<int> targetyear { get; set; }
    }
}
