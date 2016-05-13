using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SParent_Links
    {
        public int Link_Parent_ID { get; set; }
        public string Parent_Name { get; set; }
        public Nullable<int> Priority { get; set; }
    }
}
