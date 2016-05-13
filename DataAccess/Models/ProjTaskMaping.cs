using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjTaskMaping
    {
        public int slNo { get; set; }
        public Nullable<int> projId { get; set; }
        public Nullable<int> taskId { get; set; }
        public Nullable<short> orderIndex { get; set; }
    }
}
