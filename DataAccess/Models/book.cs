using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class book
    {
        public int bid { get; set; }
        public string category { get; set; }
        public string subject { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string description { get; set; }
        public string place { get; set; }
        public string status { get; set; }
    }
}
