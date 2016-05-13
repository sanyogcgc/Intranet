using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblSalesMaster1
    {
        public string PIN { get; set; }
        public string ClientId { get; set; }
        public string ProjectName { get; set; }
        public Nullable<System.DateTime> SignUpDate { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> BDId { get; set; }
        public string LeadSource_O_N { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public Nullable<int> Geography { get; set; }
        public Nullable<int> unit { get; set; }
        public Nullable<int> TL { get; set; }
        public string Payment { get; set; }
        public Nullable<int> ClientCode { get; set; }
        public string ExchangeRate { get; set; }
        public string totalINR { get; set; }
        public string ProposeEfforts { get; set; }
        public string TotalDollar { get; set; }
        public int IDS { get; set; }
        public int Project_ID { get; set; }
        public Nullable<int> ProjStatus { get; set; }
        public string Phase { get; set; }
    }
}
