using DataAccess.DAL;
using DataAccess.Models.Mapping;
using DataAccess.Repository;
using Newtonsoft.Json;
using ResourceUtilization.Controllers;
using ResourceUtilization.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace ResourceUtilization.Controllers
{
    public class HomeController : BaseController
    {
        private readonly EmployeeDa employeeDa;
        private readonly ProjectDa projectDa;
        private readonly ResourceUtilizationDa resourceDa;
        private readonly UnitOfWork unitOfWork;
        private readonly InvoiceDa invoiceDa;

        public HomeController()
        {
            unitOfWork = new UnitOfWork();
            employeeDa = new EmployeeDa(unitOfWork);
            projectDa = new ProjectDa(unitOfWork);
            resourceDa = new ResourceUtilizationDa(unitOfWork);
            invoiceDa = new InvoiceDa(unitOfWork);
        }

        [HttpGet]
        public ActionResult Index()
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


        public ActionResult fillWeek(int year)
        {
            if (DateTime.Now.Year != year)
            {
                var weekList = GetNumberOfweekList(GetWeeksInYear(year), year);
                return Json(weekList, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var weekList = GetNumberOfweekList(GetWeekNumber(DateTime.Now) + 1, year);
                return Json(weekList, JsonRequestBehavior.AllowGet);
            }
        }

        public bool hideANDshow(int projectId, int weekNumber, int year)
        {
            bool valStatus = resourceDa.GetStatus(projectId, weekNumber, year);
            return valStatus;
        }

        public bool hideANDshowInvoice(int projectId, int weekNumber, int year)
        {
            bool valStatus = invoiceDa.GetStatus(projectId, weekNumber, year);
            return valStatus;
        }

        [HttpPost]
        public ActionResult InsertData(List<ResourceViewModel> employeeViewModel)
        {
            resourceDa.InsertBulk(employeeViewModel, Convert.ToInt32(Session["Emp_id"]));
            return new JsonResult { Data = new { newLocation = "Home/Index" } };
        }


        [HttpPost]
        public JsonResult GetEmployee(int? projectId = 0, int? weekNumber = 0, int? Year = 0)
        {
            //var currentBillable = "<input id='T1_{0}' class='txtCurrentBillable' type='number'   value='{1}'   maxlength='9'  disabled  />";
            //var currentNonBillable = "<input id='T2_{0}' class='txtCurrentNonBillable' type='number'   value='{1}' disabled maxlength='9'/>";
            //var nextBillable = "<input id='T3_{0}' class='txtNextBillable' type='number'  value='{1}' {2} maxlength='9'/>";
            //var nextNonBillable = "<input id='T4_{0}' class='txtNextNonBillable' type='number'  value='{1}' {2} maxlength='9'/>"; //value='{1}'
            var currentBillable = "<input id='T3_{0}' class='txtCurrentBillable' type='number'   value='{1}'{2}  maxlength='9'  />";
            var currentNonBillable = "<input id='T4_{0}' class='txtCurrentNonBillable' type='number'   value='{1}'{2}   maxlength='9'  />";
            var nextBillable = "<input id='T1_{0}' class='txtNextBillable' type='number'  value='{1}'    maxlength='9' disabled />";
            var nextNonBillable = "<input id='T2_{0}' class='txtNextNonBillable' type='number'  value='{1}'   maxlength='9' disabled />"; //value='{1}'
            var invoiceHours = "<input id='T5_{0}' class='txtinvoiceHour' type='number'  value='{1}' {2} maxlength='9'/>";
            var empId = "<input id='T6_{0}' class='txtEmpId' type='label'   value='{1}'  maxlength='9'/>";
            var uId = "<input id='T7_{0}' class='txtId' type='label'   value='{1}'  maxlength='9'/>";
            int c = 0;
            c = 1;

            var listEmployee = employeeDa.GetEmployee(projectId.Value).Select((x, inext) => new ResourceViewModel() { uId = c++, Id = x.ID, Emp_Id = x.Emp_Id, EmployeeName = x.EmployeeName, DesignationName = x.DesignationName, Status = x.Status == true });
            var listResoureces = resourceDa.GetResouces(projectId, weekNumber, Year);
            c = 0;

            if (listEmployee != null && listEmployee.Count() > 0)
            {

                c = 1;
                var data = listEmployee.ToArray();

                var status = listResoureces[1].ToList().LastOrDefault() == null ? false : listResoureces.ToList()[1].LastOrDefault().Status;
                var rows = (from host in data
                            select new
                            {
                                Emp_Id = string.Format(empId, host.uId, host.Emp_Id),
                                host.EmployeeName,
                                host.DesignationName,
                                Id = string.Format(uId, host.uId, listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().Id : 0),
                                InvoiceHours = string.Format(invoiceHours, host.uId, listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().InvoiceHours : 0, (status == true ? "disabled" : "")),
                                //CurrentBillable = string.Format(currentBillable, host.uId, listResoureces.Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces.Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().CurrentBillable : 0),
                                //CurrentNonBillable = string.Format(currentNonBillable, host.uId, listResoureces.Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces.Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().CurrentNonBillable : 0),
                                //NextBillable = string.Format(nextBillable, host.uId, listResoureces.Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces.Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().NextBillable : 0, (status == true ? "disabled" : "")),
                                //NextNonBillable = string.Format(nextNonBillable, host.uId, listResoureces.Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces.Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().NextNonBillable : 0, (status == true ? "disabled" : "")),

                                CurrentBillable = string.Format(nextBillable, host.uId, listResoureces[0].Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces[0].Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().PreviousBillable : 0 ),
                                CurrentNonBillable = string.Format(nextNonBillable, host.uId, listResoureces[0].Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces[0].Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().PreviousNonBillable : 0),
                                NextBillable = string.Format(currentBillable, host.uId, listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().CurrentBillable : 0, (status == true ? "disabled" : "")),
                                NextNonBillable = string.Format(currentNonBillable, host.uId, listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).Count() > 0 ? listResoureces[1].Where(a => a.ResourceId == host.Emp_Id).FirstOrDefault().CurrentNonBillable : 0, (status == true ? "disabled" : "")),
                                //
                            }).ToArray();

                return Json(rows, JsonRequestBehavior.AllowGet);

            }

            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Invoice()
        {
            ResourceViewModel rm = new ResourceViewModel();
            var employeeID = Session["Emp_id"];
            if (employeeID == null)
                return RedirectToAction("Login", "Account");

            rm.ProjectList = projectDa.GetProjects(Convert.ToInt32(Session["Units"].ToString()), Convert.ToInt32(Session["Emp_id"].ToString()));
            rm.YearList = YearList().AsEnumerable();
            return View(rm);
        }
        public JsonResult GetInvoice(int? projectId = 0, int? weekNumber = 0, int? Year = 0)
        {
            if (projectId != 0 && weekNumber != 0 && Year != 0)
            {
                var PlannedHours = "<input id='T1_{0}' class='txtPlannedHours' type='number' disabled  value='{1}'   maxlength='9'    />";
                var ActualHours = "<input id='T2_{0}' class='txtActualHours' type='number' disabled  value='{1}'  maxlength='9'/>";
                var InvoiceHours = "<input id='T3_{0}' class='txtInvoiceHours' type='number'  value='{1}' {2}  maxlength='9'/>";
                var empId = "<input id='T4_{0}' class='txtEmpId' type='label'   value='{1}'  maxlength='9'/>";
                var uId = "<input id='T5_{0}' class='txtId' type='label'   value='{1}'  maxlength='9'/>";
                int c = 0;
                c = 1;
                var listResoureces = invoiceDa.GetInvoice(projectId, weekNumber, Year).Select((x, inext) => new InvoiceViewModel() { uId = c++, Id = x.Id, Emp_Id = x.Emp_Id, EmployeeName = x.EmployeeName, DesignationName = x.DesignationName, ActualHours = x.ActualHours, PlannedHours = x.PlannedHours, InvoiceHours = x.InvoiceHours, iStatus = x.iStatus });
                c = 0;

                if (listResoureces != null && listResoureces.Count() > 0)
                {

                    c = 1;
                    var data = listResoureces.ToArray();

                    var rows = (from host in data
                                select new
                                {
                                    Emp_Id = string.Format(empId, host.uId, host.Emp_Id),
                                    host.EmployeeName,
                                    host.DesignationName,
                                    Id = string.Format(uId, host.uId, host.uId),

                                    PlannedHours = string.Format(PlannedHours, host.uId, (host.PlannedHours == null ? 0 : host.PlannedHours)),
                                    ActualHours = string.Format(ActualHours, host.uId, (host.ActualHours == null ? 0 : host.ActualHours)),
                                    InvoiceHours = string.Format(InvoiceHours, host.uId, (host.InvoiceHours == null ? 0 : host.InvoiceHours), (host.iStatus == true ? "disabled" : ""), (checkZero(host.iStatus, host.InvoiceHours, host.PlannedHours, host.ActualHours) ? "disabled" : ""))
                                }).ToArray();

                    return Json(rows, JsonRequestBehavior.AllowGet);

                }
            }

            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        public bool checkZero(bool? iStatus, int? InvoiceHours, decimal? PlannedHours, decimal? ActualHours)
        {
            if (iStatus == true && InvoiceHours == null && PlannedHours == null && ActualHours == null)
                return true;
            else
                return false;
        }

        [HttpPost]
        public ActionResult InsertInvoiceDetail(List<InvoiceViewModel> invoiceViewModel)
        {
            if (invoiceViewModel != null)
            {
                invoiceDa.InsertBulkInvoice(invoiceViewModel, Convert.ToInt32(Session["Emp_id"]));
                return new JsonResult { Data = new { newLocation = "Home/Index" } };
            }
            else
            {
                return new JsonResult { Data = new { newLocation = "Home/Index" } };
            }
        }

        [HttpGet]
        public ActionResult ProjectStatus(int Pid)
        {
            List<ProjectViewModel> result = invoiceDa.ProjectStatus(Pid);
            var status = result.SingleOrDefault().IsBillable;// == null ? false : listResoureces.ToList().LastOrDefault().Status;
            return Json(status, JsonRequestBehavior.AllowGet);
        }

    }
}