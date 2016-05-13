using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("ResourceUtilization")]
    public partial class ResourceUtilization
    {
        [Key]
        public int ID { get; set; }

        public int? Emp_Id { get; set; }

        public int? CurrentBillable { get; set; }

        public int? CurrentNonBillable { get; set; }

        public int? WeekNumber { get; set; }

        public int? NextBillable { get; set; }

        public int? NextNonBillable { get; set; }

        public int? Year { get; set; }

        public int? InvoiceHours { get; set; }

        public int? ProjectId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

    }
}