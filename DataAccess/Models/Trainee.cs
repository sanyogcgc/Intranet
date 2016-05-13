using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Trainee
    {
        public int Id { get; set; }
        public Nullable<int> Event_Detail_Id { get; set; }
        public Nullable<int> Employee_Id { get; set; }
        public string Attended_Status { get; set; }
        public string Comments { get; set; }
        public virtual Event_Detail Event_Detail { get; set; }
    }
}
