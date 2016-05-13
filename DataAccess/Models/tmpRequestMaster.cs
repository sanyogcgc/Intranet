using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tmpRequestMaster
    {
        public int Reqid { get; set; }
        public string Report { get; set; }
        public System.DateTime fromDate { get; set; }
        public System.DateTime toDate { get; set; }
        public int unitID { get; set; }
        public int status { get; set; }
    }
}
