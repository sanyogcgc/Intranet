using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Status
    {
        public int status_id { get; set; }
        public string status1 { get; set; }
        public string description { get; set; }
        public Nullable<int> stat_order { get; set; }
        public Nullable<byte> Intern { get; set; }
        public Nullable<byte> Extern { get; set; }
    }
}
