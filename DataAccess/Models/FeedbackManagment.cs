using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class FeedbackManagment
    {
        public int Uid { get; set; }
        public int LoginEmp_id { get; set; }
        public int Emp_id { get; set; }
        public int EmpCode { get; set; }
        public int Supervisor { get; set; }
        public int Unit { get; set; }
        public bool Feedback { get; set; }
        public string Comment { get; set; }
        public string RmComment { get; set; }
        public Nullable<int> IsApprove { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
