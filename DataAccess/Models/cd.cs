using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class cd
    {
        public int cid { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string place { get; set; }
        public string status { get; set; }
    }
}
