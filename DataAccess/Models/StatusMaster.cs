using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class StatusMaster
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
        public Nullable<int> Active { get; set; }
    }
}
