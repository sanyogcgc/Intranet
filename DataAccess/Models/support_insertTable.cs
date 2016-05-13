using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class support_insertTable
    {
        public long supportid { get; set; }
        public Nullable<int> EMPID { get; set; }
        public string priority { get; set; }
        public string subject { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public string status { get; set; }
        public string ExpCloseTime { get; set; }
        public string systemcomments { get; set; }
        public string reopencomments { get; set; }
    }
}
