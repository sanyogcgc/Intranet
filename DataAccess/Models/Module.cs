using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Module
    {
        public int Module_Id { get; set; }
        public string Module_Name { get; set; }
        public string Module_Description { get; set; }
        public Nullable<int> Project_Id { get; set; }
    }
}
