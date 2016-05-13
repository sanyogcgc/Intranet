using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW1
    {
        public Nullable<System.DateTime> date1 { get; set; }
        public int sno { get; set; }
        public string UserName { get; set; }
        public string Project_Name { get; set; }
        public string PhaseName { get; set; }
        public Nullable<double> hours { get; set; }
        public string status { get; set; }
        public string systime { get; set; }
        public string Unit_name { get; set; }
        public string Client_Name { get; set; }
    }
}
