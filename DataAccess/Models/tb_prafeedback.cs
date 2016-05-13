using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tb_prafeedback
    {
        public int feedbackid { get; set; }
        public Nullable<int> empid { get; set; }
        public Nullable<int> rmempid { get; set; }
        public string GivenBy { get; set; }
        public string feedback { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> RMREMARKS { get; set; }
    }
}
