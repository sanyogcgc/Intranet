using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TblMilestoneService
    {
        public long SrNo { get; set; }
        public int MilestoneId { get; set; }
        public string PIN { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<double> AmtDue { get; set; }
        public Nullable<double> AmtReceived { get; set; }
    }
}
