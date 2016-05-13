using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblIpcSubjResponse
    {
        public int subjResponse_Id { get; set; }
        public Nullable<int> Userid { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> currentyear { get; set; }
        public Nullable<int> ques_Id { get; set; }
    }
}
