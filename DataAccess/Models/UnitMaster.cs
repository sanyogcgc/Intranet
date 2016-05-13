using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UnitMaster
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public Nullable<short> flag { get; set; }
    }
}
