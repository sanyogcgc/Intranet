using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Security
    {
        public int security_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
