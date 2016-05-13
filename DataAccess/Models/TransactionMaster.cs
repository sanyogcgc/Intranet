using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TransactionMaster
    {
        public int TransactionId { get; set; }
        public Nullable<int> LeadId { get; set; }
        public string Status { get; set; }
        public Nullable<int> AssignTo { get; set; }
        public Nullable<int> LeadAccept { get; set; }
        public Nullable<int> ReAssignTo { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> DateTransaction { get; set; }
        public Nullable<System.DateTime> TimeTransaction { get; set; }
    }
}
