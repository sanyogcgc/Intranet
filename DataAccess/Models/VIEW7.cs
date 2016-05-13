using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW7
    {
        public string Unit_name { get; set; }
        public string Designation_name { get; set; }
        public int EmpID { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string LeaveTypeName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<double> NumberOfLeavesAvailed { get; set; }
        public Nullable<double> NumberOfLeavesAllowed { get; set; }
    }
}
