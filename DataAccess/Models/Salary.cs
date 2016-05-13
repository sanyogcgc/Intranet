using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Salary
    {
        public int Sal_Id { get; set; }
        public Nullable<decimal> Salary1 { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> Emp_Id { get; set; }
        public Nullable<int> pmtType_Id { get; set; }
        public string pmtDetails { get; set; }
    }
}
