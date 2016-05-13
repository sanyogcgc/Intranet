using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Project
    {
        public int ID { get; set; }
        public Nullable<int> Client_Code { get; set; }
        public int Business_Developer { get; set; }
        public Nullable<int> Currency_Code { get; set; }
        public string Description { get; set; }
        public string Project_Name { get; set; }
        public Nullable<int> Solution_Type { get; set; }
        public Nullable<System.DateTime> Starting_Date { get; set; }
        public Nullable<double> Project_Cost { get; set; }
        public Nullable<int> Units { get; set; }
        public string Phase { get; set; }
        public string ProjectCode { get; set; }
        public Nullable<int> teamLeader { get; set; }
        public Nullable<int> TeamLeader_Second { get; set; }
        public Nullable<int> ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedTime { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> spoc { get; set; }
        public string pm { get; set; }
        public Nullable<double> currency_exchange_rate { get; set; }
        public Nullable<double> TotalInr { get; set; }
        public Nullable<double> TotalDollar { get; set; }
        public Nullable<int> intAccountManager { get; set; }
        public Nullable<decimal> ProposedEstEfforts { get; set; }
        public Nullable<int> ProjStatus { get; set; }
        public Nullable<bool> IsBillable { get; set; }
    }
}
