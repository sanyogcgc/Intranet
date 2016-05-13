using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class RockStarForHRG
    {
        public int UidHRG { get; set; }
        public int Emp_id { get; set; }
        public int Unit { get; set; }
        public int supervisor { get; set; }
        public int HrgEmp_id { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }
        public string Description6 { get; set; }
        public string Description7 { get; set; }
        public string Description8 { get; set; }
        public string Description9 { get; set; }
        public string Description10 { get; set; }
        public string Awards { get; set; }
        public int Quarter { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
