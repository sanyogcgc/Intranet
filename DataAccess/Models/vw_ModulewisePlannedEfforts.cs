using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vw_ModulewisePlannedEfforts
    {
        public int ProjModule_Id { get; set; }
        public string ModuleName { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<decimal> PlannedEfforts { get; set; }
    }
}
