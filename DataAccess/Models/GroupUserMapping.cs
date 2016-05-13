using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class GroupUserMapping
    {
        public int Userid { get; set; }
        public Nullable<int> Groupid { get; set; }
    }
}
