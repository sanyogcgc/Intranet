using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjMember
    {
        public long ProjMember_Id { get; set; }

        public Nullable<int> TeamMember { get; set; }

        public Nullable<int> ProjectId { get; set; }
    }
}