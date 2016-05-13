using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgTrainer
    {
        public int TrainerID { get; set; }
        public string TrainerName { get; set; }
        public Nullable<int> TrainerExp { get; set; }
        public string TrainerOrganization { get; set; }
        public string Comments { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
