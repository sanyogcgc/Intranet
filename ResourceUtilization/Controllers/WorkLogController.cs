using DataAccess.DAL;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
namespace ResourceUtilization.Controllers
{
    public class WorkLogController : BaseController
    {
        private readonly ProjectDa projectDa;
        private readonly UnitOfWork unitOfWork;

        public WorkLogController()
        {
            unitOfWork = new UnitOfWork();
            projectDa = new ProjectDa(unitOfWork);

        }
        //
        // GET: /WorkLog/
        [HttpGet] 
        public ActionResult Index()
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");
            var wl = new WorkLogViewModel
            {
                WorkLogDayList = WorkDaysList().AsEnumerable(),
                ProjectsList = projectDa.GetWorkLogProjectsName(Convert.ToInt32(Session["Emp_id"].ToString())),
                PhaseList =WorkLogPhaseList().AsEnumerable(),
                ModuleList = WorkLogModuleList().AsEnumerable(),
                TaskList= WorkLogTaskList().AsEnumerable(),
            };
            return View(wl);
        }
        [HttpGet]
        public ActionResult AddNewRow(int increment=0,int rowIndex = 2)
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");
            var wl = new WorkLogViewModel
            {
                WorkLogDayList = WorkDaysList().AsEnumerable(),
                ProjectsList = projectDa.GetWorkLogProjectsName(Convert.ToInt32(Session["Emp_id"].ToString())),
                PhaseList = WorkLogPhaseList().AsEnumerable(),
                ModuleList = WorkLogModuleList().AsEnumerable(),
                TaskList = WorkLogTaskList().AsEnumerable(),
            };
            ViewBag.RowCreated = increment+1;
            ViewBag.RowIndex = rowIndex;
            return PartialView(wl);
        }
        [HttpGet]
        public string GetString()
        {
            return "Hello";
        }
        [HttpGet]
        public JsonResult GetNewRowData()
        {
            var wl = new WorkLogViewModel
            {
                WorkLogDayList = WorkDaysList().AsEnumerable(),
                ProjectsList = projectDa.GetWorkLogProjectsName(Convert.ToInt32(Session["Emp_id"].ToString())),
                PhaseList = WorkLogPhaseList().AsEnumerable(),
                ModuleList = WorkLogModuleList().AsEnumerable(),
                TaskList = WorkLogTaskList().AsEnumerable(),
            };
            return Json(wl, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetPhase(int ProjectId = 0)
        {
            if (ProjectId != 0)
            {
                var PhaseList = projectDa.GetWorkLogPhaseListData(Convert.ToInt32(Session["Units"].ToString()));
                if (PhaseList != null && PhaseList.Count() > 0)
                {
                    return Json(PhaseList, JsonRequestBehavior.AllowGet);        
                }
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetModule(int Projectid = 0)
        {
            if (Projectid != 0)
            {
                var ModuleList = projectDa.GetWorkLogModuleListData(Convert.ToInt32(Session["Emp_Id"].ToString()), Projectid);
                if (ModuleList != null && ModuleList.Count() > 0)
                {
                    return Json(ModuleList, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTask(int Projectid = 0)
        {
            if (Projectid != 0)
            {
                var TaskList = projectDa.GetWorkLogProjTaskList(Convert.ToInt32(Session["Emp_Id"].ToString()), Convert.ToInt32(Session["Units"].ToString()), Projectid);
                if (TaskList != null && TaskList.Count() > 0)
                {
                    return Json(TaskList, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetProjectName()
        {
            var ProjectList = projectDa.GetProjectName();

            return View("Index", ProjectList);
        }
        [HttpPost]
        public JsonResult SubmitChanges(List<WorkLogViewModel> List1)
        {
            if (List1 != null && List1.Count()>0)
            {
                if (projectDa.InsertWorkLogData(List1, Convert.ToInt32(Session["Emp_Id"].ToString())) == 1)
                {

                }
                else
                {
 
                }
            }
            return Json(new {err="Not save"},JsonRequestBehavior.AllowGet);
        }
	}
}