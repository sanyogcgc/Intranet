using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class timelog
    {
        public int Sno { get; set; }
        public int ename { get; set; }
        public Nullable<System.DateTime> sysdate { get; set; }
        public string arrival { get; set; }
        public string finish { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
