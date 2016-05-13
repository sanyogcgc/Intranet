using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Currency
    {
        public int id { get; set; }
        public string Currency_Name { get; set; }
        public Nullable<decimal> Exchange_Rate { get; set; }
    }
}
