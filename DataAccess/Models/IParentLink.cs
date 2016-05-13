using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class IParentLink
    {
        public int Parent_ID { get; set; }
        public string Parent_link { get; set; }
        public Nullable<int> priority { get; set; }
    }
}
