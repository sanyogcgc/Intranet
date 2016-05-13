using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using System.Web.Mvc;

namespace DataAccess.DAL
{
    public class ReportsDa : BaseDa
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDa"/> class.
        /// </summary>
        /// <param name="unityOfWork">The unity of work.</param>
        public ReportsDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {
        }
        /// <summary>
        /// Gets by userName.
        /// </summary>
        /// <param name="userName">The userName.</param>
        /// <returns>Employee.</returns>
        public List<UtilizationViewModel> GetUtilizationReport(int units, int projectId = 0, int weekNumber = 0, int year = 0)
        {
            int empId = 0;
            var weekHours = GetWeekHours(weekNumber, year);
            var data = GetResourcePlanning(units, projectId, weekNumber, year, empId);
            data.ForEach(a => a.Utilization = ((Convert.ToDouble(a.CurrentBillable) + Convert.ToDouble(a.CurrentNonBillable)) / Convert.ToDouble(weekHours)));
            return data;
        }


        /// <summary>
        /// Gets by userName.
        /// </summary>
        /// <param name="userName">The userName.</param>
        /// <returns>Employee.</returns>
        public List<UtilizationViewModel> GetAvailabilityReport(int units, int projectId = 0, int weekNumber = 0, int year = 0)
        {
            int empId = 0;
            var weekHours = GetWeekHours(weekNumber, year);
            var data = GetResourcePlanning(units, projectId, weekNumber, year, empId);
            data.ForEach(a => a.Availability = ((Convert.ToDouble(weekHours) - Convert.ToDouble(a.CurrentBillable)) / Convert.ToDouble(weekHours)));
            return data;
        }

        /// <summary>
        /// Gets by userName.
        /// </summary>
        /// <param name="userName">The userName.</param>
        /// <returns>Employee.</returns>
        //public List<UtilizationViewModel> GetPlanningReport(int units, int projectId = 0, int weekNumber = 0, int year = 0)
        //{
        //    var data = GetResourcePlanning(units, projectId, weekNumber, year);
        //    return data;
        //}
        public List<UtilizationViewModel> GetPlanningReport(int units, int projectId = 0, int weekNumber = 0, int year = 0, int empId = 0)
        {
            var data = GetResourcePlanning(units, projectId, weekNumber, year, empId);
            return data;
        }
        private List<UtilizationViewModel> GetResourcePlanning(int units, int projectId, int weekNumber, int year, int empId)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            if (projectId != 0)
                empId = 0;

            GetWeek(Convert.ToInt32(weekNumber), Convert.ToInt32(year), out startDate, out endDate);
            var weekPlanning = from prv in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                               where prv.WeekNumber == weekNumber && (prv.ProjectId == projectId || projectId == 0) && prv.Status == true && prv.Year == year
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
                                   join p in UnitOfWork.ProjMemberRepository.GetQuery() on e.Emp_id equals p.TeamMember into t
                                   from pt in t.DefaultIfEmpty()
                                   join m in UnitOfWork.EmployeeRepository.GetQuery() on e.supervisor equals m.Emp_id
                                   where e.Status == "Current" && (pt.ProjectId == projectId || projectId == 0) && e.Unit == units && e.supervisor == empId
                                   orderby e.Fname
                                   select new
                                   {
                                       Emp_Id = e.Emp_id,
                                       DesignationName = d.Designation_name,
                                       EmployeeName = e.Fname + " " + e.Mname + " " + e.Lname,
                                       ManagerName = m.Fname + " " + m.Mname + " " + m.Lname
                                   }).Distinct();

            var data = (from det in employeeDetails
                        join pln in weekPlanning on det.Emp_Id equals pln.Emp_Id
                        into pln1
                        from pln in pln1.DefaultIfEmpty()
                        //join wlog in WorkLogDetail on pln.Emp_Id equals wlog.Emp_Id
                        //join inv in invoiceDetail on det.Emp_Id equals inv.Emp_Id





                        join wlog in WorkLogDetail on det.Emp_Id equals wlog.Emp_Id
                        into wlog1
                        from wlog in wlog1.DefaultIfEmpty()
                        join inv in invoiceDetail on det.Emp_Id equals inv.Emp_Id into inv1
                        from inv in inv1.DefaultIfEmpty()
                        // into details
                        //  from detailsResult in details.DefaultIfEmpty()
                        orderby det.EmployeeName
                        select new UtilizationViewModel
                        {
                            Emp_Id = det.Emp_Id,
                            EmployeeName = det.EmployeeName,
                            ManagerName = det.ManagerName,
                            DesignationName = det.DesignationName,
                            //  ActualHours = wlog.Units,
                            // InvoiceHours = inv.InvoiceHours,
                            CurrentBillable = pln.CurrentBillable,//detailsResult == null ? 0 : detailsResult.CurrentBillable, 
                            CurrentNonBillable = pln.CurrentNonBillable,//detailsResult == null ? 0 : detailsResult.CurrentNonBillable,

                        }).Distinct().ToList();
            var weekHours = GetWeekHours(weekNumber, year);
            data.ForEach(a => a.PlannedHours = (a.CurrentBillable) + (a.CurrentNonBillable));
            data.ForEach(a => a.Utilization = ((Convert.ToDouble(a.CurrentBillable) + Convert.ToDouble(a.CurrentNonBillable)) / Convert.ToDouble(weekHours)));// added by Ankit
            data.ForEach(a => a.Availability = ((Convert.ToDouble(weekHours) - Convert.ToDouble(a.CurrentNonBillable)) / Convert.ToDouble(weekHours)));
            return data;
        }


        public List<InvoiceViewModel> GetDetailReport(int units, int projectId, int weekNumber, int year)
        {
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
                                iStatus = inv.iStatus,
                                ManagerName = det.ManagerName,
                            }).Distinct().ToList();

                data.RemoveAll(a => a.PlannedHours == 0 && a.ActualHours == 0 && a.InvoiceHours == 0 && a.Status != "Current");
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UtilizationViewModel> GetPlanningReportAll(int units, int weekNumber, int year, int empId, int rType)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            if (rType == 2)
                empId = 0;
            
            GetWeek(Convert.ToInt32(weekNumber), Convert.ToInt32(year), out startDate, out endDate);
            var weekPlanning = from prv in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                               where prv.WeekNumber == weekNumber && prv.Status == true && prv.Year == year
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
                                where wlr.ForDate >= startDate && wlr.ForDate <= endDate 
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
          
           
             var    employeeDetails = (from e in UnitOfWork.EmployeeRepository.GetQuery()
                                       join p in UnitOfWork.ProjMemberRepository.GetQuery() on e.Emp_id equals p.TeamMember into t
                                       from pt in t.DefaultIfEmpty()
                                       join d in UnitOfWork.DesignationRepository.GetQuery() on e.Designation_id equals d.Designation_id

                                       join m in UnitOfWork.EmployeeRepository.GetQuery() on e.supervisor equals m.Emp_id
                                       where e.Status == "Current" && e.Unit == units// && (e.supervisor == empId || e.supervisor == 0)
                                       orderby e.Fname
                                       select new
                                       {
                                           Emp_Id = e.Emp_id,
                                           DesignationName = d.Designation_name,
                                           EmployeeName = e.Fname + " " + e.Mname + " " + e.Lname,
                                           ManagerName = m.Fname + " " + m.Mname + " " + m.Lname,
                                           pt.ProjectId
                                       }).Distinct();
            

            var data = (from det in employeeDetails
                        join pln in weekPlanning on det.Emp_Id equals pln.Emp_Id
                        into pln1
                        from pln in pln1.DefaultIfEmpty()
                        //join wlog in WorkLogDetail on pln.Emp_Id equals wlog.Emp_Id
                        //join inv in invoiceDetail on det.Emp_Id equals inv.Emp_Id





                        join wlog in WorkLogDetail on det.Emp_Id equals wlog.Emp_Id
                        into wlog1
                        from wlog in wlog1.DefaultIfEmpty()
                        //join inv in invoiceDetail on det.Emp_Id equals inv.Emp_Id into inv1
                        //from inv in inv1.DefaultIfEmpty()
                        // into details
                        //  from detailsResult in details.DefaultIfEmpty()
                        orderby det.EmployeeName
                        select new UtilizationViewModel
                        {
                            Emp_Id = det.Emp_Id,
                            EmployeeName = det.EmployeeName,
                            ManagerName = det.ManagerName,
                            DesignationName = det.DesignationName,
                            CurrentBillable = pln.CurrentBillable,//detailsResult == null ? 0 : detailsResult.CurrentBillable, 
                            CurrentNonBillable = pln.CurrentNonBillable,//detailsResult == null ? 0 : detailsResult.CurrentNonBillable,

                        }).Distinct().ToList();
            var weekHours = GetWeekHours(weekNumber, year);
            data.ForEach(a => a.PlannedHours = (a.CurrentBillable) + (a.CurrentNonBillable));
            data.ForEach(a => a.Utilization = ((Convert.ToDouble(a.CurrentBillable) + Convert.ToDouble(a.CurrentNonBillable)) / Convert.ToDouble(weekHours)));// added by Ankit
            data.ForEach(a => a.Availability = ((Convert.ToDouble(weekHours) - Convert.ToDouble(a.CurrentNonBillable)) / Convert.ToDouble(weekHours)));
            return data;
        }

        public List<UtilizationViewModel> GetPlanningReportPrj(int units, int weekNumber, int year, int empId, int rType)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            if (rType == 2)
                empId = 0;

            GetWeek(Convert.ToInt32(weekNumber), Convert.ToInt32(year), out startDate, out endDate);
            var weekPlanning = from prv in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                               where prv.WeekNumber == weekNumber && prv.Status == true && prv.Year == year
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
                                where wlr.ForDate >= startDate && wlr.ForDate <= endDate
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


            var employeeDetails = (from e in UnitOfWork.EmployeeRepository.GetQuery()
                                   join p in UnitOfWork.ProjMemberRepository.GetQuery() on e.Emp_id equals p.TeamMember into t
                                   from pt in t.DefaultIfEmpty()
                                   join d in UnitOfWork.DesignationRepository.GetQuery() on e.Designation_id equals d.Designation_id

                                   join m in UnitOfWork.EmployeeRepository.GetQuery() on e.supervisor equals m.Emp_id
                                   where e.Status == "Current" && e.Unit == units// && (e.supervisor == empId || e.supervisor == 0)
                                   orderby e.Fname
                                   select new
                                   {
                                       Emp_Id = e.Emp_id,
                                       DesignationName = d.Designation_name,
                                       EmployeeName = e.Fname + " " + e.Mname + " " + e.Lname,
                                       ManagerName = m.Fname + " " + m.Mname + " " + m.Lname,
                                       pt.ProjectId
                                   }).Distinct();
            var ProjectCmn = (from pm in UnitOfWork.ProjMemberRepository.GetQuery()
                              where pm.TeamMember == empId
                              select new { 
                               pm.ProjectId
                              });


            var data = (from det in employeeDetails
                        join pln in weekPlanning on det.Emp_Id equals pln.Emp_Id
                        into pln1
                        from pln in pln1.DefaultIfEmpty()
                        //join wlog in WorkLogDetail on pln.Emp_Id equals wlog.Emp_Id
                        //join inv in invoiceDetail on det.Emp_Id equals inv.Emp_Id

                        join wlog in WorkLogDetail on det.Emp_Id equals wlog.Emp_Id
                        into wlog1
                        from wlog in wlog1.DefaultIfEmpty()

                        join pcmn in ProjectCmn on det.ProjectId equals pcmn.ProjectId 
                        //into pcv
                        //from pcmn in pcv.DefaultIfEmpty()
                        //join inv in invoiceDetail on det.Emp_Id equals inv.Emp_Id into inv1
                        //from inv in inv1.DefaultIfEmpty()
                        // into details
                        //  from detailsResult in details.DefaultIfEmpty()
                        orderby det.EmployeeName
                        select new UtilizationViewModel
                        {
                            Emp_Id = det.Emp_Id,
                            EmployeeName = det.EmployeeName,
                            ManagerName = det.ManagerName,
                            DesignationName = det.DesignationName,
                            CurrentBillable = pln.CurrentBillable,//detailsResult == null ? 0 : detailsResult.CurrentBillable, 
                            CurrentNonBillable = pln.CurrentNonBillable,//detailsResult == null ? 0 : detailsResult.CurrentNonBillable,

                        }).Distinct().ToList();
            var weekHours = GetWeekHours(weekNumber, year);
            data.ForEach(a => a.PlannedHours = (a.CurrentBillable) + (a.CurrentNonBillable));
            data.ForEach(a => a.Utilization = ((Convert.ToDouble(a.CurrentBillable) + Convert.ToDouble(a.CurrentNonBillable)) / Convert.ToDouble(weekHours)));// added by Ankit
            data.ForEach(a => a.Availability = ((Convert.ToDouble(weekHours) - Convert.ToDouble(a.CurrentNonBillable)) / Convert.ToDouble(weekHours)));
            return data;
        }
    }
}
