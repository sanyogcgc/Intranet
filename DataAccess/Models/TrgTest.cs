using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TrgTest
    {
        public int TrgTestID { get; set; }
        public Nullable<int> TrgID { get; set; }
        public string TestName { get; set; }
        public string TrgTstDescription { get; set; }
        public string MinMarks { get; set; }
        public string PostorPre { get; set; }
    }
}
