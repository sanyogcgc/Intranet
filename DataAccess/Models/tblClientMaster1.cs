using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblClientMaster1
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public Nullable<int> BDId { get; set; }
        public Nullable<int> GeographyId { get; set; }
        public Nullable<int> LeadSourceId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public Nullable<int> BusinessCategoryId { get; set; }
        public Nullable<int> PaymentId { get; set; }
        public Nullable<int> AccountPriorityId { get; set; }
        public int ClientIds { get; set; }
    }
}
