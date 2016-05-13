using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TempEmployee
    {
        public string lname { get; set; }
        public int emp_id { get; set; }
        public Nullable<int> unit { get; set; }
    }
}
