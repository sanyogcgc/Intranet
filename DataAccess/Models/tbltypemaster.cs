using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tbltypemaster
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
