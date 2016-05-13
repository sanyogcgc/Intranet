using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SubUnit
    {
        public int SubUnitID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public string SubUnitName { get; set; }
        public string Abbv { get; set; }
    }
}
