using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgTraining
    {
        public int TrgID { get; set; }
        public string TrgName { get; set; }
        public string TrgDescription { get; set; }
        public Nullable<double> Duration { get; set; }
        public Nullable<bool> PreTest { get; set; }
        public Nullable<bool> PostTest { get; set; }
        public Nullable<int> TrainerID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Purpose { get; set; }
        public string Objective { get; set; }
        public string Agenda { get; set; }
        public string Deliverable { get; set; }
        public string Pre { get; set; }
        public string Success { get; set; }
        public string SubCategory { get; set; }
    }
}
