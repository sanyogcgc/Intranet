using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCProcess
    {
        public int Type_Id { get; set; }
        public string Description { get; set; }
        public Nullable<short> Category { get; set; }
        public Nullable<short> ActiveFlag { get; set; }
    }
}
