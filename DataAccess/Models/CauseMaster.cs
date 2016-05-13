using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CauseMaster
    {
        public int CauseID { get; set; }
        public string CauseName { get; set; }
        public string ApplicableInAttendance { get; set; }
        public string ApplicableInLeave { get; set; }
    }
}
