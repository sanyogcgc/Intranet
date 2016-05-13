using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SAM_Role
    {
        public int SAM_Role_Slno { get; set; }
        public Nullable<int> Role_ID { get; set; }
        public Nullable<int> Group_ID { get; set; }
        public Nullable<int> Emp_ID { get; set; }
    }
}
