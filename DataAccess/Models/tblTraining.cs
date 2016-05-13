using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblTraining
    {
        public int TrainingID { get; set; }
        public string TrainingName { get; set; }
        public Nullable<int> flag { get; set; }
    }
}
