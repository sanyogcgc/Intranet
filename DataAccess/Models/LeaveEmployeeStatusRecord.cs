using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveEmployeeStatusRecord
    {
        public int EmpID { get; set; }
        public int LeaveTypeID { get; set; }
        public Nullable<double> NumberOfLeavesAvailed { get; set; }
        public Nullable<double> NumberOfLeavesLeft { get; set; }
        public Nullable<double> NumberOfLeavesAllowed { get; set; }
    }
}
