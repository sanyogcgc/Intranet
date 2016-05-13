using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblBDMaster
    {
        public int BDId { get; set; }
        public string BDName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public Nullable<int> serviceid { get; set; }
        public string BDM { get; set; }
    }
}
