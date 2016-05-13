using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblCurrencyExchange
    {
        public int SerialNo { get; set; }
        public int CurrencyId { get; set; }
        public Nullable<double> INRExchangeAmout { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public Nullable<int> years { get; set; }
        public string months { get; set; }
    }
}
