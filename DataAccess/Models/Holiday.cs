using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Holiday
    {
        public int Holiday_Id { get; set; }
        public Nullable<System.DateTime> Holiday_Date { get; set; }
        public string Holiday_Name { get; set; }
        public string Restricted_Holiday { get; set; }
    }
}
