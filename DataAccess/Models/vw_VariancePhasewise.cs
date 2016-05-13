using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vw_VariancePhasewise
    {
        public string PhaseName { get; set; }
        public Nullable<decimal> PlannedEfforts { get; set; }
        public int ActualEfforts { get; set; }
        public Nullable<int> phaseid { get; set; }
        public string Remarks { get; set; }
        public string ProjectName { get; set; }
        public Nullable<int> ProjId { get; set; }
        public Nullable<decimal> ProposedEstEfforts { get; set; }
    }
}
