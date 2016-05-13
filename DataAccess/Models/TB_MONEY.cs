using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TB_MONEY
    {
        public int moneyid { get; set; }
        public Nullable<int> EMPID { get; set; }
        public Nullable<int> MONEY { get; set; }
        public string REASON { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> DonateEMPID { get; set; }
        public string Department { get; set; }
        public string month { get; set; }
    }
}
