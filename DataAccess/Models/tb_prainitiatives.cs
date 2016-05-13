using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tb_prainitiatives
    {
        public int InitiativeID { get; set; }
        public Nullable<int> empid { get; set; }
        public string Initiatives { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> RMREMARKS { get; set; }
    }
}
