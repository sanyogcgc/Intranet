using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjectTime
    {
        public int sno { get; set; }
        public int pid { get; set; }
        public Nullable<int> phaseid { get; set; }
        public Nullable<int> subphaseid { get; set; }
        public string ManDays { get; set; }
        public string Remarks { get; set; }
    }
}
