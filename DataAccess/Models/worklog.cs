using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class worklog
    {
        public int sno { get; set; }
        public Nullable<System.DateTime> date1 { get; set; }
        public Nullable<int> uid { get; set; }
        public Nullable<int> pid { get; set; }
        public Nullable<double> hours { get; set; }
        public string status { get; set; }
        public string systime { get; set; }
        public Nullable<int> module { get; set; }
        public Nullable<int> unit_id { get; set; }
        public Nullable<System.DateTime> sysdate { get; set; }
    }
}
