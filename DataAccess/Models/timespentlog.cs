using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class timespentlog
    {
        public int sno { get; set; }
        public int ename { get; set; }
        public Nullable<System.DateTime> sysdate { get; set; }
        public string timespent { get; set; }
        public string partner { get; set; }
        public string back_up { get; set; }
        public string cleanliness { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
