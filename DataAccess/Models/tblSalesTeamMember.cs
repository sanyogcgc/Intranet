using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblSalesTeamMember
    {
        public int SerialNo { get; set; }
        public int TeamId { get; set; }
        public int BDId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
