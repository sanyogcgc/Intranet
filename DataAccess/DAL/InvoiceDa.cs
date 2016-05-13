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
    public class InvoiceDa : BaseDa
    {
        public InvoiceDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {
        }
        public Employee GetEmployee(string userName, string password)
        {
            return UnitOfWork.EmployeeRepository.Get(c => c.UserName == userName && c.Pwd == password && c.Status == "Current").FirstOrDefault();
        }
        public IEnumerable<InvoiceViewModel> GetInvoice(int? projectId = 0, int? weekNumber = 0, int? year = 0)
        {
            // var aa = UnitOfWork.EmployeeRepository.Get(c => c.UserName == "sankumar").FirstOrDefault();
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            try
            {
                GetWeek(Convert.ToInt32(weekNumber), Convert.ToInt32(year), out startDate, out endDate);
                var weekPlanning = from prv in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                                   where prv.WeekNumber == weekNumber && (prv.ProjectId == projectId) && prv.Year == year
                                   group new
                                   {
                                       prv.Emp_Id,
                                       prv.CurrentBillable,
                                       prv.CurrentNonBillable
                                   }
                                 by
                                 new
                                 {
                                     prv.Emp_Id
                                 }
                                       into g
                                       select new
                                       {
                                           Emp_Id = g.Key.Emp_Id == null ? 0 : g.Key.Emp_Id,
                                           CurrentBillable = g.Sum(s => s.CurrentBillable),
                                           CurrentNonBillable = g.Sum(s => s.CurrentNonBillable),
                                       };
                var WorkLogDetail = from wlr in UnitOfWork.WorkLogRepository.GetQuery()
                                    where wlr.ForDate >= startDate && wlr.ForDate <= endDate && (wlr.ProjId == projectId)
                                    group new
                                    {
                                        wlr.UserId,
                                        wlr.Units
                                    }
                                    by new
                                    {
                                        wlr.UserId
                                    } into g
                                    select new
                                    {
                                        Emp_Id = g.Key.UserId == null ? 0 : g.Key.UserId,
                                        Units = g.Sum(s => s.Units)
                                    };

                var invoiceDetail = from ir in UnitOfWork.InvoiceRepository.GetQuery()
                                    where ir.WeekNumber == weekNumber && (ir.ProjectId == projectId) && ir.Year == year
                                    select new
                                    {
                                        Emp_Id = ir.Emp_Id,
                                        InvoiceHours = ir.InvoiceHours,
                                        iStatus = ir.iStatus
                                    };
                var employeeDetails = (from e in UnitOfWork.EmployeeRepository.GetQuery()
                                       join d in UnitOfWork.DesignationRepository.GetQuery() on e.Designation_id equals d.Designation_id
                                       join p in UnitOfWork.ProjMemberRepository.GetQuery() on e.Emp_id equals p.TeamMember
                                       join m in UnitOfWork.EmployeeRepository.GetQuery() on e.supervisor equals m.Emp_id
                                       where (p.ProjectId == projectId)
                                       orderby e.Fname
                                       select new
                                       {
                                           Emp_Id = e.Emp_id,
                                           DesignationName = d.Designation_name,
                                           EmployeeName = e.Fname + " " + e.Mname + " " + e.Lname,
                                           ManagerName = m.Fname + " " + m.Mname + " " + m.Lname,
                                           Status = e.Status
                                       });

                var data = (from det in employeeDetails
                            join pln in weekPlanning on det.Emp_Id equals pln.Emp_Id into pln1
                            from pln in pln1.DefaultIfEmpty()
                            join wlog in WorkLogDetail on pln.Emp_Id equals wlog.Emp_Id into wlog1
                            from wlog in wlog1.DefaultIfEmpty()
                            join inv in invoiceDetail on det.Emp_Id equals inv.Emp_Id into inv1
                            from inv in inv1.DefaultIfEmpty()
                            orderby det.EmployeeName
                            select new InvoiceViewModel
                            {
                                Emp_Id = det.Emp_Id,
                                EmployeeName = det.EmployeeName,
                                DesignationName = det.DesignationName,
                                PlannedHours = (decimal)((pln.CurrentBillable) + (pln.CurrentNonBillable)),
                                ActualHours = (decimal)wlog.Units,
                                InvoiceHours = inv.InvoiceHours,
                                Status = det.Status,
                                iStatus = inv.iStatus
                            }).Distinct().ToList();

                data.RemoveAll(a => a.PlannedHours == 0 && a.ActualHours == 0 && a.InvoiceHours == 0 && a.Status == "Current");
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool GetStatus(int projectId = 0, int weekNumber = 0, int year = 0)
        {
            var data = UnitOfWork.InvoiceRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == weekNumber && x.ProjectId == projectId && x.Year == year);
            if (data != null)
            {
                return Convert.ToBoolean(data.iStatus);
            }
            else
            {
                return false;
            }
        }
        public void InsertBulkInvoice(List<InvoiceViewModel> resources, int currentUser)
        {
            try
            {
                Invoice ru1 = new Invoice();
                ru1 = UnitOfWork.InvoiceRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == resources.FirstOrDefault().WeekNumber && x.ProjectId == resources.FirstOrDefault().ProjectId);
                if (ru1 != null)
                {

                    foreach (var item in resources.ToList().Select(x => new Invoice() { Id = Convert.ToInt32(x.Id), Emp_Id = x.Emp_Id, InvoiceHours = Convert.ToInt32(x.InvoiceHours), ProjectId = Convert.ToInt32(x.ProjectId), CreatedDate = System.DateTime.Now, iStatus = x.iStatus, WeekNumber = Convert.ToInt32(x.WeekNumber), Year = Convert.ToInt32(x.Year), ModifiedBy = currentUser }).ToList())
                    {
                        Invoice inv = new Invoice();
                        inv = UnitOfWork.InvoiceRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == item.WeekNumber && x.Emp_Id == item.Emp_Id && x.ProjectId == item.ProjectId);
                        if (inv != null)
                        {
                            inv = UnitOfWork.InvoiceRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == item.WeekNumber && x.Emp_Id == item.Emp_Id && x.ProjectId == item.ProjectId);
                            inv.Emp_Id = item.Emp_Id;
                            inv.InvoiceHours = item.InvoiceHours;
                            inv.ProjectId = item.ProjectId;
                            inv.WeekNumber = item.WeekNumber;
                            inv.Year = item.Year;
                            inv.ModifiedDate = System.DateTime.Now;
                            inv.iStatus = item.iStatus;
                            inv.ModifiedBy = currentUser;
                            UnitOfWork.InvoiceRepository.Update(inv);
                            UnitOfWork.InvoiceRepository.context.SaveChanges();
                        }
                    }

                }
                else
                {
                    UnitOfWork.InvoiceRepository.BulkInsert(resources.ToList().Select(x => new Invoice() { Emp_Id = x.Emp_Id, InvoiceHours = x.InvoiceHours, ProjectId = x.ProjectId, CreatedDate = System.DateTime.Now, iStatus = x.iStatus, WeekNumber = x.WeekNumber, Year = x.Year, CreatedBy = currentUser }).ToList());
                    UnitOfWork.InvoiceRepository.context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProjectViewModel> ProjectStatus(int Pid)
        {
    
                 var result = (from  p in UnitOfWork.ProjectRepository.GetQuery()
                               where p.ID == Pid
                              select new ProjectViewModel()
                              {
                                  //ID = e.ID,
                                  //ClientProject = ep.Client_Name + "/" + e.Project_Name,
                                  //Units = e.Units,
                                  //TeamLeader = e.teamLeader,
                                  IsBillable = p.IsBillable
                              }).Distinct().ToList();
            return result;
        }

    }
}
