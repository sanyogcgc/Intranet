using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class trainingrequest
    {
        public int UID { get; set; }
        public Nullable<int> Emp_id { get; set; }
        public string Priority { get; set; }
        public string Department { get; set; }
        public string Subject { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
