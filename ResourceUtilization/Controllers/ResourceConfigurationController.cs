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
    public class ResourceConfigurationController : BaseController
    {
        private readonly ProjectDa projectDa;
        private readonly UnitOfWork unitOfWork;

        public ResourceConfigurationController()
        {
            unitOfWork = new UnitOfWork();
            projectDa = new ProjectDa(unitOfWork);

        }
        //
        // GET: /ResourceConfiguration/
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");
            var rc = new ResourceConfigurationViewModel()
            {
                TechnologyGroupList = projectDa.GetTechnologyList().AsEnumerable(),
                EmployeeList = EmployeeListforTech().AsEnumerable()
            };
            return View(rc);
        }

        public ActionResult AddNewProjectConfigToResource(int isEdit =0, int TechId = 0)
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");
           var rc = new ResourceConfigurationViewModel();
           var list = projectDa.GetResourcebyID(isEdit);
           var GetProjectList = projectDa.GetProject();
                //var projectList = new ResourceConfigurationViewModel()
                //{
                //    //  GetProjectList = projectDa.GetProject()
                //    GetProjectList = projectDa.GetProject(),
                   

                //};
            list.ToList();
           rc.GetProjectList = GetProjectList;
           rc.EmployeeList =  projectDa.GetEmployeeFromTechnology(TechId);
           if (list != null)
           {
               foreach (ResourceConfigurationViewModel item in list)
              {
                  rc.StartDate = item.StartDate;
                  rc.EndTime = item.EndTime;
                  rc.ProjectId = item.ProjectId;
                  rc.Allocation = item.Allocation;
                  rc.Id = item.Id;
                  rc.empName = item.empName;
                  rc.EmpID = item.EmpID;
              
              }           
           }
          
           rc.GetProjectList = GetProjectList;
            //rc.StartDate= list
           return PartialView("AddNewProjectConfigToResource", rc);
        }

        public JsonResult GetEmployeeList(int Technology_id)
        {
            if (Technology_id != 0)
            {
                var emplist = projectDa.GetEmployeeFromTechnology(Technology_id);
                if (emplist!=null && emplist.Count()>0)
                {
                    return Json(emplist, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SubmitChanges(List<ResourceConfigurationViewModel> List1, int RscdId=0)
        {
            int idCkh=0;
            foreach (ResourceConfigurationViewModel item in List1)
            {
                 idCkh = item.Id;
            }

            if (idCkh > 0)
            {
                if (List1 != null && List1.Count() > 0)
                {

                    ResourceConfigurationViewModel rs = new ResourceConfigurationViewModel();
                    rs.Id = projectDa.UpdateResourceConfigurationData(List1, RscdId, Convert.ToInt32(Session["Emp_id"]));
                    return Json(rs, JsonRequestBehavior.AllowGet);
                }           
            }
            else
            {
                if (List1 != null && List1.Count() > 0)
                {

                    ResourceConfigurationViewModel rs = new ResourceConfigurationViewModel();
                    rs.Id = projectDa.SaveResourceConfigurationData(List1, RscdId, Convert.ToInt32(Session["Emp_id"]));
                    return Json(rs, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult GetData(GridSettings grid, int RscId)
        {
            var btn = "<input type='button' id='btn_{0}' class='txtId' onclick='clickrow();'  value='Edit'  maxlength='9'/>";
            if (RscId == 0  )
                return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
            if (RscId != 0)
            {
                if (grid.SortColumn == "")
                    grid.SortColumn = "ProjName";
                var RscList = projectDa.GetResourceList(RscId);
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
        public JsonResult GetDataAll(GridSettings grid, int RscId, int? RourceId)
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
                var RscList = projectDa.GetResourceListAll(RscId, RourceId);
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