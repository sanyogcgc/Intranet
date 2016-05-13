using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblLeadSourceMaster
    {
        public int LeadSourceId { get; set; }
        public string LeadSourceName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
