using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblIpcSubjectiveQue
    {
        public int SubQues_id { get; set; }
        public string Subques { get; set; }
        public Nullable<int> catid { get; set; }
    }
}
