using DataAccess.DAL;
using DataAccess.Repository;
using ResourceUtilization.HtmlHelpers.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModel;
using System.Data;
using NPOI.HSSF.UserModel;//For using NPOI dll 


namespace ResourceUtilization.Controllers
{
    public class ReportController : BaseController
    {
        private readonly EmployeeDa employeeDa;
        private readonly ProjectDa projectDa;
        private readonly ResourceUtilizationDa resourceDa;
        private readonly ReportsDa reportsDa;
        private readonly UnitOfWork unitOfWork;

        public ReportController()
        {
            unitOfWork = new UnitOfWork();
            employeeDa = new EmployeeDa(unitOfWork);
            projectDa = new ProjectDa(unitOfWork);
            resourceDa = new ResourceUtilizationDa(unitOfWork);
            reportsDa = new ReportsDa(unitOfWork);

        }

        [HttpGet]
        public ActionResult ResourcePlanning()
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");

            var rm = new ResourceViewModel
            {
                ProjectList = projectDa.GetProjects(Convert.ToInt32(Session["Units"].ToString()), Convert.ToInt32(Session["Emp_id"].ToString())),
                YearList = YearList().AsEnumerable()
            };
            return View(rm);
        }

        [HttpGet]
        public ActionResult ResourceUtilization()
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");

            var rm = new ResourceViewModel
            {
                ProjectList = projectDa.GetProjects(Convert.ToInt32(Session["Units"].ToString()), Convert.ToInt32(Session["Emp_id"].ToString())),
                YearList = YearList().AsEnumerable()
            };
            return View(rm);
        }

        [HttpGet]
        public ActionResult ResourceAvailability()
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");

            var rm = new ResourceViewModel
            {
                ProjectList = projectDa.GetProjects(Convert.ToInt32(Session["Units"].ToString()), Convert.ToInt32(Session["Emp_id"].ToString())),
                YearList = YearList().AsEnumerable()
            };
            return View(rm);
        }

        public ActionResult DetailedReport()
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");

            var rm = new ResourceViewModel
            {
                ProjectList = projectDa.GetProjects(Convert.ToInt32(Session["Units"].ToString()), Convert.ToInt32(Session["Emp_id"].ToString())),
                YearList = YearList().AsEnumerable()
            };
            return View(rm);
        }

        [HttpPost]
        public JsonResult GetUtilizationReport(GridSettings grid, int projectId = 0, int weekNumber = 0, int year = 0)
        {
            if (projectId == 0 && weekNumber == 0 && year == 0)
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);

            var list = reportsDa.GetUtilizationReport(Convert.ToInt32(Session["Units"].ToString()), projectId, weekNumber, year);

            if (list != null && list.Count() > 0)
            {
                var data = list.ToArray();
                var rows = (from host in data
                            select new
                            {
                                host.Emp_Id,
                                host.EmployeeName,
                                host.DesignationName,
                                host.ManagerName,
                                host.CurrentBillable,
                                host.CurrentNonBillable,
                                Total = host.CurrentBillable + host.CurrentNonBillable,
                                Utilization = Math.Round((host.Utilization * 100), 2) + "%"
                            }).ToArray();

                return ReturnSortedResult(rows, grid);
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetAvailabilityReport(GridSettings grid, int projectId = 0, int weekNumber = 0, int year = 0)
        {
            if (projectId == 0 && weekNumber == 0 && year == 0)
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);

            var list = reportsDa.GetAvailabilityReport(Convert.ToInt32(Session["Units"].ToString()), projectId, weekNumber, year);

            if (list != null && list.Count() > 0)
            {
                var data = list.ToArray();
                var rows = (from host in data
                            select new
                            {
                                host.Emp_Id,
                                host.EmployeeName,
                                host.DesignationName,
                                host.ManagerName,
                                host.CurrentBillable,
                                host.CurrentNonBillable,
                                Total = host.CurrentBillable + host.CurrentNonBillable,
                                Availability = Math.Round((host.Availability * 100), 2) + "%"
                            }).ToArray();

                return ReturnSortedResult(rows, grid);
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetDetailReport(GridSettings grid, int projectId = 0, int weekNumber = 0, int year = 0)
        {
            if (projectId == 0 && weekNumber == 0 && year == 0)
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);

            var list = reportsDa.GetDetailReport(Convert.ToInt32(Session["Units"].ToString()), projectId, weekNumber, year);

            if (list != null && list.Count() > 0)
            {
                var data = list.ToArray();
                var rows = (from host in data
                            select new
                            {
                                host.Emp_Id,
                                host.EmployeeName,
                                host.DesignationName,
                                host.ManagerName,
                                Planned = host.PlannedHours,
                                Actual = host.ActualHours,
                                Invoiced = host.InvoiceHours
                            }).ToArray();

                return ReturnSortedResult(rows, grid);
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetPlanningReport(GridSettings grid, int projectId = 0, int weekNumber = 0, int year = 0, int empId = 0)
        {
            if (projectId == 0 && weekNumber == 0 && year == 0)
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
            if (projectId == 2)
                empId = 0;
            else
                empId = Convert.ToInt32(Session["Emp_id"].ToString());

            List<UtilizationViewModel> list = null;
            if(projectId== 0)
             list = reportsDa.GetPlanningReport(Convert.ToInt32(Session["Units"].ToString()), projectId, weekNumber, year, empId);
             if(projectId== 2)
             list = reportsDa.GetPlanningReportAll(Convert.ToInt32(Session["Units"].ToString()), weekNumber, year, empId, projectId);
             if(projectId== 1)
                 list = reportsDa.GetPlanningReportPrj(Convert.ToInt32(Session["Units"].ToString()), weekNumber, year, empId, projectId);
            
            Session["rows"] = list;
            if (list != null && list.Count() > 0)
            {
                var data = list.ToArray();
                var rows = (from host in data
                            select new
                            {
                                host.Emp_Id,
                                host.EmployeeName,
                                host.DesignationName,
                                host.ManagerName,
                                PlannedHours = host.PlannedHours == null ? 0 : host.PlannedHours,                             
                                Utilization = Math.Round((host.Utilization * 100), 2) + "%",
                                Availability = Math.Round((host.Availability * 100), 2) + "%"
                            }).ToArray();

                return ReturnSortedResult(rows, grid);
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetProject()
        {
            var rm = new ResourceViewModel
            {
                ProjectList = projectDa.GetProjects(Convert.ToInt32(Session["Units"].ToString()), Convert.ToInt32(Session["Emp_id"].ToString())),
                YearList = YearList().AsEnumerable()
            };
            return Json(rm, JsonRequestBehavior.AllowGet);
        }

    }
}