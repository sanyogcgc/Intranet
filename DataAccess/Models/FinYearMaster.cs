using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class FinYearMaster
    {
        public int FinYearID { get; set; }
        public string FinYear { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
    }
}
