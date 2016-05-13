using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjLead
    {
        public int ProjLead_Id { get; set; }
        public Nullable<int> TeamLeader { get; set; }
        public Nullable<int> ProjectId { get; set; }
    }
}
