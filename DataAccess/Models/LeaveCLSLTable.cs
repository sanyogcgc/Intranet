using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeaveCLSLTable
    {
        public int Sno { get; set; }
        public string Month { get; set; }
        public Nullable<double> NoCL { get; set; }
        public Nullable<double> NoSL { get; set; }
    }
}
