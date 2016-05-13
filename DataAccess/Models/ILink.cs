using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ILink
    {
        public int Link_ID { get; set; }
        public Nullable<int> Parent_ID { get; set; }
        public string Link_Text { get; set; }
        public string Link_URL { get; set; }
        public string Group_ID { get; set; }
        public bool Activate_Bit { get; set; }
        public Nullable<int> priority { get; set; }
    }
}
