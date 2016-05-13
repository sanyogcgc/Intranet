using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgSchedule
    {
        public int TrgSchID { get; set; }
        public Nullable<int> TrgID { get; set; }
        public Nullable<System.DateTime> TrgSchDate { get; set; }
        public string TrgSchTime { get; set; }
        public Nullable<int> TrgVnuID { get; set; }
        public Nullable<System.DateTime> TrgSchCutoffDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> TrainerID { get; set; }
        public string TrainerName { get; set; }
    }
}
