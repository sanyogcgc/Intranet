using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date_Sent { get; set; }
        public Nullable<System.DateTime> Date_Received { get; set; }
        public string Title { get; set; }
        public Nullable<float> USBank { get; set; }
        public Nullable<float> IndiaBank { get; set; }
        public Nullable<float> EEFC { get; set; }
        public Nullable<float> Cash { get; set; }
        public Nullable<int> Transferring_AC { get; set; }
        public Nullable<float> Total_Amt { get; set; }
        public Nullable<float> Currency_Exchange_Rate { get; set; }
        public Nullable<int> Transaction_Type { get; set; }
        public string Comments { get; set; }
    }
}
