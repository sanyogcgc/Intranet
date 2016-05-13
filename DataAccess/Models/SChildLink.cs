using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SChildLink
    {
        public int Child_Links_ID { get; set; }
        public Nullable<int> Parent_Link_ID { get; set; }
        public string Child_Text { get; set; }
        public string Child_URL { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
