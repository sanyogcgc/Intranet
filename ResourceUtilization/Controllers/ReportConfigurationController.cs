using DataAccess.DAL;
using DataAccess.Repository;
using ResourceUtilization.HtmlHelpers.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace ResourceUtilization.Controllers
{
    public class ReportConfigurationController : BaseController
    {

        private readonly ProjectDa projectDa;
        private readonly UnitOfWork unitOfWork;

        public ReportConfigurationController()
        {
            unitOfWork = new UnitOfWork();
            projectDa = new ProjectDa(unitOfWork);
        }
        //
        // GET: /ReportConfiguration/
        public ActionResult Index()
        {

            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");

            var rc = new ResourceConfigurationViewModel()
            {
                TechnologyGroupList = projectDa.GetTechnologyList().ToList(),
                EmployeeList = EmployeeListforTech().ToList()
            };

            return View(rc);
        }

        [HttpPost]
        public JsonResult GetDataAll(GridSettings grid, int RscId, int? RourceId, DateTime? Todate, DateTime? FromDate)
        
        {
            var btn = "<input type='button' id='btn_{0}' class='txtId' onclick='clickrow();'  value='Edit'  maxlength='9'/>";
            if (RscId == 0)
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
            if (RscId != 0)
            {
                if (RourceId == 0)
                {
                    RourceId = null;
                }
                if (grid.SortColumn == "")
                    grid.SortColumn = "ProjName";
                var RscList = projectDa.GetResourceListDatewise(RscId, RourceId, FromDate, Todate);
                if (RscList != null && RscList.Count() > 0)
                {
                    var data = RscList.ToArray();
                    var rows = (from host in data
                                select new
                                {

                                    host.ProjName,
                                    host.StartDate,
                                    host.EndTime,
                                    host.Allocation,
                                    host.Id,
                                    host.empName,
                                    host.EmpID,
                                    host.Technology_Name,
                                    host.ManagerName,
                                    //btn = host.id
                                    btn = string.Format(btn, host.Id, (host.Id == null ? 0 : host.Id)),
                                    //Total = host.CurrentBillable + host.CurrentNonBillable,
                                    //Availability = Math.Round((host.Availability * 100), 2) + "%"
                                }).ToArray();
                    return ReturnSortedResult(rows, grid);
                }

            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetData(GridSettings grid, int RscId, DateTime? Todate, DateTime? FromDate)
        {
            var btn = "<input type='button' id='btn_{0}' class='txtId' onclick='clickrow();'  value='Edit'  maxlength='9'/>";
            if (RscId == 0)
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
            if (RscId != 0)
            {
                if (grid.SortColumn == "")
                    grid.SortColumn = "ProjName";
                var RscList = projectDa.GetResourceDatewiseSubGrid(RscId, FromDate, Todate);
                if (RscList != null && RscList.Count() > 0)
                {
                    var data = RscList.ToArray();
                    var rows = (from host in data
                                select new
                                {

                                    host.ProjName,
                                    host.StartDate,
                                    host.EndTime,
                                    host.Allocation,
                                    host.Id,
                                    //btn = host.id
                                    btn = string.Format(btn, host.Id, (host.Id == null ? 0 : host.Id)),

                                    //Total = host.CurrentBillable + host.CurrentNonBillable,
                                    //Availability = Math.Round((host.Availability * 100), 2) + "%"
                                }).ToArray();
                    return ReturnSortedResult(rows, grid);
                }

            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult GetDataDetails(GridSettings grid, int RscId, DateTime? Todate, DateTime? FromDate, int? RourceId)
        {
            var btn = "<input type='button' id='btn_{0}' class='txtId' onclick='clickrow();'  value='Edit'  maxlength='9'/>";
            if (RscId == 0)
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
            if (RscId != 0)
            {
                if (grid.SortColumn == "")
                    grid.SortColumn = "ProjName";
                var RscList = projectDa.GetResourceDatewiseDetails(RscId, FromDate, Todate);
                if (RscList != null && RscList.Count() > 0)
                {
                    var data = RscList.ToArray();
                    var rows = (from host in data
                                select new
                                {

                                    host.ProjName,
                                    host.StartDate,
                                    host.EndTime,
                                    host.Allocation,
                                  //  host.Id,
                                    host.empName,
                                 
                                    //btn = host.id
                                    btn = string.Format(btn, host.Id, (host.Id == null ? 0 : host.Id)),

                                    //Total = host.CurrentBillable + host.CurrentNonBillable,
                                    //Availability = Math.Round((host.Availability * 100), 2) + "%"
                                }).ToArray();
                    return ReturnSortedResult(rows, grid);
                }

            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

    }
}