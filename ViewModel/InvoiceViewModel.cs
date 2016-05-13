using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class InvoiceViewModel
    {
        public int? Id { get; set; }

        public int? uId { get; set; }

        public int Year { get; set; }

        public decimal? PlannedHours { get; set; }

        public decimal? ActualHours { get; set; }
        
        public string DesignationName { get; set; }

        public int? InvoiceHours { get; set; }

        public int? WeekNumber { get; set; }

        public string EmployeeName { get; set; }

        public string ManagerName { get; set; }

        public int Emp_Id { get; set; }

        public int? ProjectId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }
        // for current users in Employee table
        public string Status { get; set; }
        // for Invoice table
        public bool? iStatus { get; set; }
    }
}
