using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblStatusMaster
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
