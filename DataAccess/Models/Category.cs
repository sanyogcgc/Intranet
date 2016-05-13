using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Category
    {
        public int category_id { get; set; }
        public string category_desc { get; set; }
        public string description { get; set; }
        public Nullable<int> cat_order { get; set; }
    }
}
