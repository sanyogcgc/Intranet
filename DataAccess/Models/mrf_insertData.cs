using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class mrf_insertData
    {
        public long MRFID { get; set; }
        public Nullable<int> EMPID { get; set; }
        public string priority { get; set; }
        public string department { get; set; }
        public string HWtype { get; set; }
        public string HWDetails { get; set; }
        public string type { get; set; }
        public string usgaeTimeFrame { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> submitDate { get; set; }
        public string status { get; set; }
        public string ExpCloseTime { get; set; }
        public string systemcomments { get; set; }
        public string RmComments { get; set; }
    }
}
