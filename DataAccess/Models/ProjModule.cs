using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjModule
    {
        public ProjModule()
        {
            this.WorkLog1 = new List<WorkLog1>();
        }

        public int ProjModule_Id { get; set; }
        public string ModuleName { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> PhaseId { get; set; }
        public Nullable<decimal> ModuleTime { get; set; }
        public virtual ICollection<WorkLog1> WorkLog1 { get; set; }
    }
}
