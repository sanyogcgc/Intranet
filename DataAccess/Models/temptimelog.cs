using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class temptimelog
    {
        public decimal sno { get; set; }
        public int ename { get; set; }
        public Nullable<System.DateTime> sysdate { get; set; }
        public string tempout { get; set; }
        public string tempin { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
