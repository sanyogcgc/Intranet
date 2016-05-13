using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Priority
    {
        public int priority_id { get; set; }
        public string priority_code { get; set; }
        public string priority_desc { get; set; }
        public Nullable<int> priority_order { get; set; }
        public string priority_color { get; set; }
    }
}
