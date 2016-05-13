using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Cat_SubCat_For_RDB
    {
        public int Id { get; set; }
        public Nullable<int> Cat_Id { get; set; }
        public Nullable<int> Sub_Cat_Id { get; set; }
    }
}
