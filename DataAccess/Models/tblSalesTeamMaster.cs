using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblSalesTeamMaster
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public string SalesTeamhead { get; set; }
    }
}
