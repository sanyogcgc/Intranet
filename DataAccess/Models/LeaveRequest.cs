using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveRequest
    {
        public int RequestID { get; set; }
        public string RequestDate { get; set; }
        public string IsCompOff { get; set; }
        public Nullable<int> LeaveCategoryId { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public string TimeTypeFrom { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string TimeTypeTo { get; set; }
        public Nullable<int> CauseID { get; set; }
        public string OtherCause { get; set; }
        public string Status { get; set; }
        public Nullable<int> SupervisorID { get; set; }
        public Nullable<System.DateTime> Comp_fordate { get; set; }
        public string RequestTo { get; set; }
        public string RequestCc { get; set; }
        public string UpdatedOn { get; set; }
        public Nullable<int> Leave_Auth_Id { get; set; }
    }
}
