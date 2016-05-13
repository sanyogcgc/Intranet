using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class v1
    {
        public int Emp_id { get; set; }
        public string Fname { get; set; }
        public string Project_Name { get; set; }
        public Nullable<int> Unit { get; set; }
        public int ID { get; set; }
        public Nullable<int> Units { get; set; }
        public Nullable<int> ProjStatus { get; set; }
    }
}
