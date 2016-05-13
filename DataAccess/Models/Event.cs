using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Event
    {
        public int Event_Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public string Category { get; set; }
    }
}
