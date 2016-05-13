using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tbl_SystemDown
    {
        public int sdid { get; set; }
        public Nullable<int> uid { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
        public string internet { get; set; }
        public string intranet { get; set; }
        public string exchange { get; set; }
        public string SoftwareInstall { get; set; }
        public string Hardware { get; set; }
        public string slowInternet { get; set; }
        public string Others { get; set; }
        public Nullable<double> Hours { get; set; }
    }
}
