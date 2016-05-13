using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class trainingcalenderForm
    {
        public int TC_ID { get; set; }
        public int CatagoryID { get; set; }
        public int TrainingID { get; set; }
        public string Trainer { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
        public Nullable<int> Quarter { get; set; }
        public string participants { get; set; }
        public string Objective { get; set; }
        public Nullable<int> flag { get; set; }
        public string TrainingStatus { get; set; }
    }
}
