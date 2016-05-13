using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class AttendanceApproval
    {
        public long ApprovalID { get; set; }
        public int EmpID { get; set; }
        public System.DateTime ForDate { get; set; }
        public string ReasonForNoPunch { get; set; }
        public System.DateTime SubmitDate { get; set; }
        public Nullable<int> TLStatus { get; set; }
        public string TLComments { get; set; }
        public Nullable<System.DateTime> TLResponseDate { get; set; }
        public Nullable<int> HRGStatus { get; set; }
        public string HRGComments { get; set; }
        public Nullable<System.DateTime> HRGResponseDate { get; set; }
        public string PunchMode { get; set; }
        public string PunchTime { get; set; }
        public string PunchInTime { get; set; }
        public string PunchOutTime { get; set; }
    }
}
