using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UNIT_SPECIFIC
    {
        public Nullable<int> emp_id { get; set; }
        public string unit_name { get; set; }
        public string empname { get; set; }
        public string designation_name { get; set; }
        public Nullable<System.DateTime> Doj { get; set; }
        public Nullable<double> CLallowed { get; set; }
        public Nullable<double> CLallotted { get; set; }
        public Nullable<double> SLallowed { get; set; }
        public Nullable<double> SLallotted { get; set; }
        public Nullable<double> PLallowed { get; set; }
        public Nullable<double> PLallotted { get; set; }
        public Nullable<double> ALallowed { get; set; }
        public Nullable<double> ALallotted { get; set; }
        public Nullable<double> RHallowed { get; set; }
        public double RHallotted { get; set; }
        public Nullable<double> workonsunday { get; set; }
        public Nullable<double> splLleaves { get; set; }
        public string spreason { get; set; }
        public Nullable<double> pending { get; set; }
        public Nullable<double> saldeduction { get; set; }
        public Nullable<System.DateTime> fromdate { get; set; }
        public Nullable<System.DateTime> todate { get; set; }
    }
}
