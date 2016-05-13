using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblServicesMaster
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public string ServiceAbb { get; set; }
    }
}
