using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Exp_Sub_Category
    {
        public int ID { get; set; }
        public Nullable<int> Category_Code { get; set; }
        public string Sub_Category { get; set; }
    }
}
