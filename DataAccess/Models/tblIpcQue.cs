using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblIpcQue
    {
        public int Ques_Id { get; set; }
        public string Ques { get; set; }
        public Nullable<int> SubCat_Id { get; set; }
    }
}
