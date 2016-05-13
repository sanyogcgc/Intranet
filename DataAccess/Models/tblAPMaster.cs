using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblAPMaster
    {
        public int APId { get; set; }
        public string APName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
