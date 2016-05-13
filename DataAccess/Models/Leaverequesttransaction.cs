using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Leaverequesttransaction
    {
        public long LeaveRequestID { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string ReasonForLeave { get; set; }
        public Nullable<int> LeaveTypeID { get; set; }
        public Nullable<double> NoOfLeaves { get; set; }
        public string PriorNotice { get; set; }
        public Nullable<int> DaysPriorNotice { get; set; }
        public string HalfDay { get; set; }
        public Nullable<System.DateTime> LeaveSubmitDate { get; set; }
        public string TLComments { get; set; }
        public Nullable<int> TLApprovalStatusID { get; set; }
        public Nullable<System.DateTime> TLResponseDate { get; set; }
        public string HRGComments { get; set; }
        public Nullable<int> HRGApprovalStatusID { get; set; }
        public Nullable<System.DateTime> HRGResponseDate { get; set; }
        public string UnitHeadComments { get; set; }
        public Nullable<int> UnitHeadApprovalStatusID { get; set; }
        public Nullable<System.DateTime> UnitHeadResponseDate { get; set; }
        public string Leave { get; set; }
        public string fullday { get; set; }
    }
}
