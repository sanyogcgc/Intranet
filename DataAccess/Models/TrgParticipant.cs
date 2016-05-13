using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgParticipant
    {
        public int TrgSchID { get; set; }
        public string participants { get; set; }
        public string Invited { get; set; }
        public int Emp_ID { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public Nullable<bool> Attended { get; set; }
        public Nullable<bool> FeedBack { get; set; }
        public Nullable<bool> flag { get; set; }
    }
}
