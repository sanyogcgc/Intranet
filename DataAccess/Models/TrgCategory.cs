using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public Nullable<bool> SubCategory { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
