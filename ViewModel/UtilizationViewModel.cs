using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UtilizationViewModel
    {
        
        public string EmployeeName { get; set; }

        public string ManagerName { get; set; }

        public int Emp_Id { get; set; }

        public string DesignationName { get; set; }

        public int? CurrentBillable { get; set; }

        public int? CurrentNonBillable { get; set; }

        public double Utilization { get; set; }

        public double Availability { get; set; }

        public decimal? PlannedHours { get; set; }

        public decimal? ActualHours { get; set; }

        public int? InvoiceHours { get; set; }  
    }
}
