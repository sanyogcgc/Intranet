using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Account_Name { get; set; }
        public Nullable<decimal> Amount { get; set; }
    }
}
