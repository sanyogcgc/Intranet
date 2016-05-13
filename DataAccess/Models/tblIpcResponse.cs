using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblIpcResponse
    {
        public int Response_Id { get; set; }
        public Nullable<int> Userid { get; set; }
        public Nullable<int> Ratingid { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> currentyear { get; set; }
        public Nullable<int> ques_Id { get; set; }
    }
}
