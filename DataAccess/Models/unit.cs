using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class unit
    {
        public int Unit_id { get; set; }
        public string Unit_name { get; set; }
        public Nullable<short> flag { get; set; }
        public Nullable<int> UnitHeadEmpId { get; set; }
    }
}
