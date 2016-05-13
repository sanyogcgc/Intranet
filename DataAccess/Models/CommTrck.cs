using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CommTrck
    {
        public int CommTrackId { get; set; }
        public Nullable<int> CommId { get; set; }
        public Nullable<int> pid { get; set; }
        public Nullable<System.DateTime> MeetingDate { get; set; }
        public string venue { get; set; }
        public Nullable<int> interacted { get; set; }
        public string duration { get; set; }
        public string objective { get; set; }
        public string minofcomm { get; set; }
        public string Comments { get; set; }
        public string PitchingStage { get; set; }
    }
}
