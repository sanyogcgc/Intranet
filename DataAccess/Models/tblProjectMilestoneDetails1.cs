using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblProjectMilestoneDetails1
    {
        public int MilestoneId { get; set; }
        public string PIN { get; set; }
        public string MilestoneDescription { get; set; }
        public Nullable<System.DateTime> DatePlanned { get; set; }
        public string DateReceived { get; set; }
        public string Comments { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public string months { get; set; }
        public Nullable<int> years { get; set; }
        public string status { get; set; }
        public string payment { get; set; }
        public Nullable<int> years1 { get; set; }
    }
}
