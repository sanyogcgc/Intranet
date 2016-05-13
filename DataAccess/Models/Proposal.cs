using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Proposal
    {
        public int ProId { get; set; }
        public Nullable<System.DateTime> ProDate { get; set; }
        public Nullable<int> CurId { get; set; }
        public string Worth { get; set; }
        public Nullable<int> pid { get; set; }
    }
}
