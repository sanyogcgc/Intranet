using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveReportingGroup
    {
        public int employeeId { get; set; }
        public string employeeFname { get; set; }
        public string employeeMname { get; set; }
        public string employeeLname { get; set; }
        public string employeeEmailID { get; set; }
    }
}
