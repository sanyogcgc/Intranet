using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccess.Models
{
   [Table("Invoice")]
    public partial class Invoice
    {
        [Key]
        public int Id { get; set; }

        public int? Emp_Id { get; set; }

        public int? InvoiceHours { get; set; }

        public int? ProjectId { get; set; }

        public int? WeekNumber { get; set; }

        public int? Year { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }
        
        public DateTime? ModifiedDate { get; set; }

        public bool? iStatus { get; set; }
    }
}
