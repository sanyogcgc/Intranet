using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ResourceWorklogViewModel
    {
        public int? ID { get; set; }

        public DateTime? OfficeDate { get; set; }

        public string Status { get; set; }

        public int? EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string InTime { get; set; }

        public string OutTime { get; set; }

        public string TotalTime { get; set; }

        public int? EmployeeCode { get; set; }
    }
}