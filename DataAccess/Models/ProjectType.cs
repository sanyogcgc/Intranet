using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjectType
    {
        public int PTypeId { get; set; }
        public Nullable<int> Unit_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
