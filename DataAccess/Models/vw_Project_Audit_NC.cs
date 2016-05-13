using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class vw_Project_Audit_NC
    {
        public int Audit_Id { get; set; }
        public Nullable<int> NoOfNCs { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Observation { get; set; }
        public int GoodObservation { get; set; }
    }
}
