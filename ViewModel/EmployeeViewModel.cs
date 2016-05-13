using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }

        public int Emp_Id { get; set; }

        public int ProjectId { get; set; }

        public string DesignationName { get; set; }

        public string EmployeeName { get; set; }

        public string CurrentBillable { get; set; }

        public string Year { get; set; }

        public string CurrentNonBillable { get; set; }

        public string WeekNumber { get; set; }

        public string NextBillable { get; set; }

        public string NextNonBillable { get; set; }

        public string InvoiceHours { get; set; }

        public bool Status { get; set; }

        public string StatusString { get; set; }

        public string Fname { get; set; }

        public string Mname { get; set; }

        public string Lname { get; set; }

        public int? Technology_ID { get; set; }
    }
}