using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PatOnTheBackAward
    {
        public int Uid { get; set; }
        public int Emp_id { get; set; }
        public int Unit { get; set; }
        public int supervisor { get; set; }
        public bool ClientAppreciation { get; set; }
        public string RMfeedback { get; set; }
        public string Awards { get; set; }
        public int Quarter { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
