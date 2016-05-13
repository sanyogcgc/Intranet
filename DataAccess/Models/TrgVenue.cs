using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgVenue
    {
        public int VenueID { get; set; }
        public string VenueName { get; set; }
        public string VenueDesc { get; set; }
        public Nullable<int> Capicity { get; set; }
        public Nullable<bool> WhiteBoard { get; set; }
        public Nullable<bool> Projector { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
