using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class tblPaymentMaster
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
    }
}
