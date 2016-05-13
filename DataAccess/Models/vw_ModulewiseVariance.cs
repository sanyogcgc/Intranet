using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vw_ModulewiseVariance
    {
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string ModuleName { get; set; }
        public Nullable<decimal> PlannedEfforts { get; set; }
        public int ActualEfforts { get; set; }
        public string ProjectName { get; set; }
        public Nullable<decimal> ProposedEstEfforts { get; set; }
    }
}
