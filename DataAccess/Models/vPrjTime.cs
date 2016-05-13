using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vPrjTime
    {
        public string ManDays { get; set; }
        public string PhaseName { get; set; }
        public int PhaseId { get; set; }
        public int ID { get; set; }
        public string Client_Name { get; set; }
        public Nullable<System.DateTime> Starting_Date { get; set; }
        public string Project_Name { get; set; }
        public int pid { get; set; }
        public string Group_Name { get; set; }
        public Nullable<int> subphaseid { get; set; }
        public int Unit_id { get; set; }
        public string Unit_name { get; set; }
    }
}
