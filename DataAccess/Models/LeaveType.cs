using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveType
    {
        public int LeaveTypeID { get; set; }
        public string LeaveTypeName { get; set; }
        public string LeaveDescription { get; set; }
        public Nullable<int> LeaveTypeAllotted { get; set; }
        public Nullable<System.DateTime> StartYearDate { get; set; }
        public Nullable<System.DateTime> EndYearDate { get; set; }
        public string Ltypes { get; set; }
    }
}
