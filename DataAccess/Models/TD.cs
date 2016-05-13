using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TD
    {
        public int ID { get; set; }
        public Nullable<int> Category_Code { get; set; }
        public Nullable<int> SubCategory_Code { get; set; }
        public Nullable<int> RevnId { get; set; }
        public Nullable<int> Project_Code { get; set; }
        public Nullable<int> Employee_Code { get; set; }
        public string Title { get; set; }
        public Nullable<float> Amount_Spent { get; set; }
        public Nullable<System.DateTime> Date_Paid { get; set; }
        public Nullable<int> Transaction_Type { get; set; }
        public Nullable<int> Currency_Code { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<float> Current_Exchange_Rate { get; set; }
        public Nullable<int> Vendor { get; set; }
        public Nullable<int> ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedTime { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<double> TotalInr { get; set; }
        public Nullable<double> TotalDollar { get; set; }
    }
}
