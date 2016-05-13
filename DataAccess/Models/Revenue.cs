using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Revenue
    {
        public int ID { get; set; }
        public Nullable<double> Project_Code { get; set; }
        public string Description { get; set; }
        public Nullable<double> Amount_Received { get; set; }
        public Nullable<System.DateTime> Date_Received { get; set; }
        public Nullable<double> Transaction { get; set; }
        public Nullable<double> Currency_Code { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<float> Current_Exchange_Rate { get; set; }
        public Nullable<int> ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedTime { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<double> TotalInr { get; set; }
        public Nullable<double> TotalDollar { get; set; }
    }
}
