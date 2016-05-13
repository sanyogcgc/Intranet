using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess.DAL
{
    public class EmployeeDa : BaseDa
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDa"/> class.
        /// </summary>
        /// <param name="unityOfWork">The unity of work.</param>
        public EmployeeDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {
        }

        /// <summary>
        /// Gets by userName.
        /// </summary>
        /// <param name="userName">The userName.</param>
        /// <returns>Employee.</returns>
        public Employee GetEmployee(string userName)
        {
            return UnitOfWork.EmployeeRepository.Get(c => c.UserName == userName).FirstOrDefault();
        }

        /// <summary>
        /// Gets by userName  & password.
        /// </summary>
        /// <param name="userName">The userName.</param>
        /// /// <param name="password">The password.</param>
        /// <returns>Employee.</returns>
        public Employee GetEmployee(string userName, string password)
        {
            return UnitOfWork.EmployeeRepository.Get(c => c.UserName == userName && c.Pwd == password && c.Status == "Current").FirstOrDefault();
        }

        public IEnumerable<EmployeeViewModel> GetEmployee(int projectId)
        {
            var result = (from e in UnitOfWork.EmployeeRepository.GetQuery()
                          join d in UnitOfWork.DesignationRepository.GetQuery() on e.Designation_id equals d.Designation_id
                          join p in UnitOfWork.ProjMemberRepository.GetQuery() on e.Emp_id equals p.TeamMember
                          where e.Status == "Current" && p.ProjectId == projectId
                          orderby e.Fname
                          select new EmployeeViewModel
                          {
                              
                              Emp_Id = e.Emp_id,
                              DesignationName = d.Designation_name,
                              EmployeeName = e.Fname + " " + e.Mname + " " + e.Lname,
                              Status=false
                          }).ToList();
            return result;
        }
    }
}