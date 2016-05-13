using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SubCat_For_RDB
    {
        public int Sub_Cat_Id { get; set; }
        public string Sub_Cat_Name { get; set; }
        public Nullable<int> Cat_Id { get; set; }
    }
}
