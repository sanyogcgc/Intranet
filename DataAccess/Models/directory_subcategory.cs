using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class directory_subcategory
    {
        public int subcategoryid { get; set; }
        public Nullable<int> categoryid { get; set; }
        public string subcategory { get; set; }
    }
}
