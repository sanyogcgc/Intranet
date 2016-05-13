using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ResourceViewModel
    {
        public int? ResourceId { get; set; }

        public int? ProjectId { get; set; }

        public int? Id { get; set; }

        public int? uId { get; set; }

        public string EmployeeName { get; set; }

        public int? Emp_Id { get; set; }

        public string DesignationName { get; set; }

        public int? CurrentBillable { get; set; }

        public int? CurrentNonBillable { get; set; }

        public int? NextBillable { get; set; }

        public int? NextNonBillable { get; set; }

        public int Year { get; set; }

        public int? InvoiceHours { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public IEnumerable<ProjectViewModel> ProjectList { get; set; }

        public IEnumerable<WeekViewModel> WeeKList { get; set; }

        public int SelectedWeek { get; set; }

        public IEnumerable<YearViewModel> YearList { get; set; }

        public int SelectedYear { get; set; }

        public int? WeekNumber { get; set; }

        public ProjectViewModel SelectedProject { get; set; }

        public bool? Status { get; set; }

        public string StatusString { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public int? PreviousBillable { get; set; }

        public int? PreviousNonBillable { get; set; }
    }
}