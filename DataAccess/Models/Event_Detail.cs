using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Event_Detail
    {
        public Event_Detail()
        {
            this.Trainees = new List<Trainee>();
        }

        public int Event_Detail_Id { get; set; }
        public Nullable<int> Event_Id { get; set; }
        public string Agenda { get; set; }
        public string Trainer { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public string ETime { get; set; }
        public string Status { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
