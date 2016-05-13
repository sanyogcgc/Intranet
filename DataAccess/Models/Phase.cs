using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Phase
    {
        public int PhaseId { get; set; }
        public string PhaseName { get; set; }
        public Nullable<int> BusinessUnitID { get; set; }
        public Nullable<bool> ActiveFlag { get; set; }
    }
}
