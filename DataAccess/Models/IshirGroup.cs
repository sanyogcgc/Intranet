using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class IshirGroup
    {
        public Nullable<int> EscalationHead { get; set; }
        public string Groupname { get; set; }
        public int Groupid { get; set; }
        public Nullable<int> Groupleaderid { get; set; }
        public string EscalationEmailid { get; set; }
        public string GroupleaderEmailid { get; set; }
    }
}
