using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class cdtracking
    {
        public int sno { get; set; }
        public string title { get; set; }
        public Nullable<System.DateTime> tdate { get; set; }
        public Nullable<int> uid { get; set; }
        public Nullable<System.DateTime> rdate { get; set; }
        public string vouchid { get; set; }
    }
}
