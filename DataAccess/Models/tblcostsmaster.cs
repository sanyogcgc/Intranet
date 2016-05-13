using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblcostsmaster
    {
        public int CostId { get; set; }
        public string Cost { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
