using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProjTask
    {
        public int ProjTask_Id { get; set; }
        public string TaskName { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> Phase { get; set; }
        public Nullable<int> BusinessUnitID { get; set; }
        public Nullable<bool> ActiveFlag { get; set; }
    }
}
