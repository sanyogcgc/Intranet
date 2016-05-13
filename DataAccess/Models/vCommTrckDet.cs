using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vCommTrckDet
    {
        public Nullable<System.DateTime> MeetingDate { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string duration { get; set; }
        public string venue { get; set; }
        public string objective { get; set; }
        public string minofcomm { get; set; }
        public string Comments { get; set; }
        public string PitchingStage { get; set; }
        public int Unit_id { get; set; }
        public int ID { get; set; }
    }
}
