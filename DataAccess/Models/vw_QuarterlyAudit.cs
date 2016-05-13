using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vw_QuarterlyAudit
    {
        public Nullable<int> Sch_Audit_Year { get; set; }
        public Nullable<int> Sch_Audit_Quarter { get; set; }
        public int Audit_Id { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Observation { get; set; }
        public int GoodObservation { get; set; }
        public Nullable<int> NoOfNCs { get; set; }
    }
}
