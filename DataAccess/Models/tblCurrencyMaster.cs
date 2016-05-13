using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblCurrencyMaster
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
