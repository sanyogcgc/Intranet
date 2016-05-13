using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblProjectDurationDetail
    {
        public int SerialNo { get; set; }
        public string PIN { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<double> ManMonthAllocated { get; set; }
        public Nullable<double> ValueAllocated { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
