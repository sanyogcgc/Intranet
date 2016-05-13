using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjActivity
    {
        public int ProjActivity_Id { get; set; }
        public string ActivityName { get; set; }
        public Nullable<int> ActivityType { get; set; }
    }
}
