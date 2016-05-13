using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblbcmaster
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
