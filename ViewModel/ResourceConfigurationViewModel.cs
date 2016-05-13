using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
     public class ResourceConfigurationViewModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ProjName { get; set; }
        public ProjectsViewModel ProjectName { get; set; }
        //[DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        public DateTime? EndTime { get; set; }
        public Double Allocation { get; set; }
        public int EmpID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public Boolean Status { get; set; }
        public string empName { get; set; }
        public string Technology_Name { get; set; }

        public string ManagerName { get; set; }
         public EmployeeDetailViewModel EmployeeDetail { get; set; }
         public IEnumerable<EmployeeDetailViewModel> EmployeeList { get; set; }
         public TechnologyGroupViewModel TechnologyGroup { get; set; }
         public IEnumerable<TechnologyGroupViewModel> TechnologyGroupList { get; set; }
         public IEnumerable<ProjectsViewModel> GetProjectList { get; set; }
         //public IEnumerable<ResourceConfigurationViewModel> ResourceConfigurationList { get; set; }
    }
    public class TechnologyGroupViewModel
    {
         public int Id { get; set; }
         public string Technology_Name { get; set; }

    }
    public class EmployeeDetailViewModel
    {
        public int Emp_Id { get; set; }
        public string EmpName { get; set; }
    }
    //public class ResourceConfiguration
    //{
    //    public int Id { get; set; }
    //    public int ProjectId { get; set; }
    //    public string ProjName { get; set; }
    //    public DateTime? StartDate { get; set; }
    //    public DateTime? EndTime { get; set; }
    //    public decimal Allocation { get; set; }
    //    public int EmpID { get; set; }
    //    public DateTime? CreatedOn { get; set; }
    //    public int CreatedBy { get; set; }
    //    public DateTime? ModifiedOn { get; set; }
    //    public int ModifiedBy { get; set; }
    //    public Boolean Status { get; set; }
    //}
}
