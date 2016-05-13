using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using System.Data;
using DataAccess.DAL;
using DataAccess.Repository;

namespace ResourceUtilization.Controllers
{
    public class ProjectConfigController : Controller
    {
        private readonly EmployeeDa employeeDa;
        private readonly ProjectDa projectDa;
        private readonly UnitOfWork unitOfWork;
        private readonly ProjectConfigDa ProjectConfigDa;

        public ProjectConfigController()
        {
            unitOfWork = new UnitOfWork();
            employeeDa = new EmployeeDa(unitOfWork);
            projectDa = new ProjectDa(unitOfWork);
            ProjectConfigDa = new ProjectConfigDa(unitOfWork);
            // resourceDa = new ResourceUtilizationDa(unitOfWork);
            // reportsDa = new ReportsDa(unitOfWork);
        }

        //
        // GET: /ProjectConfig/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProjectConfig()
        {
            if (Session["Emp_id"] == null)
                return RedirectToAction("Login", "Account");
            var rm = new ProjectConfigViewModel
            {
                ProjectList = projectDa.GetProjects(Convert.ToInt32(Session["Units"].ToString()), Convert.ToInt32(Session["Emp_id"].ToString())),
                phaseList = ProjectConfigDa.GetPhase(Convert.ToInt32(Session["Units"].ToString())),
                taskList = ProjectConfigDa.GetTask(Convert.ToInt32(Session["Units"].ToString())),
                unitList = ProjectConfigDa.GetUnitBusiness(),
                EmployeeList = ProjectConfigDa.GetAllEmployee(),

            };
            return View(rm);
        }

        [HttpGet]
        public JsonResult GetProposedEstEfforts(int projectId)
        {
            int? unit = Convert.ToInt32(Session["Units"].ToString());
            //var rm = new ProjectConfigViewModel
            //{
            ProjectConfigViewModel pc = ProjectConfigDa.GetProposedEstEfforts(projectId);
            pc.phaseList = ProjectConfigDa.GetPhaseTimeProjectWise(projectId);
            pc.ProjModuleList = ProjectConfigDa.GetModuleProjectWise(projectId);
            pc.taskList = ProjectConfigDa.GetTaskProjectWise(projectId);
            pc.EmployeeList = ProjectConfigDa.GetEmployeeProjectWise(projectId);
            int tl = ProjectConfigDa.GetTeamLeaderProjectWise(projectId, unit.Value);
            pc.TeamLeader = tl;
            return Json(pc, JsonRequestBehavior.AllowGet);

            // return Json(new { err = "errmsg" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetEmployeeUnitWise(int unitID)
        {

            ProjectConfigViewModel pc = new ProjectConfigViewModel();
            pc.EmployeeList = ProjectConfigDa.GetEmployeeUnitWise(unitID);
            return Json(pc, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        //  public JsonResult SubmitChanges(List<ProjectConfigViewModel> ProjectTimeViewModel)
        public JsonResult SubmitChanges(List<ProjectConfigViewModel> Phase, List<ProjectConfigViewModel> Module, List<ProjectConfigViewModel> Task, List<ProjectConfigViewModel> Team, int teamlead,int secondTL)
        {

            // List<ProjectTimeViewModel> lstPhase = new List<ProjectTimeViewModel>();
            //lstPhase.AddRange(ProjectTimeViewModel[0].ToList());
            int projectID = Phase.FirstOrDefault().ProjectId;
           
            ProjectConfigViewModel pc = new ProjectConfigViewModel();
            if(Phase!=null)
            { 
            var lst = Phase.ToList();
            lst.ToList();
            int i = ProjectConfigDa.UpdateAllRecord(lst);
            }

            if (Module != null)
            {
                var lstModule = Module.ToList();
                lstModule.ToList();
                int j = ProjectConfigDa.ChangeModule(lstModule);
            }


            if (Task != null)
            {
                var lsttask = Task.ToList();
                lsttask.ToList();
                int k = ProjectConfigDa.ChangeTaskDetails(lsttask);
            }

            if (Team != null)
            {
                var lstTeam = Team.ToList();
                lstTeam.ToList();
                int l = ProjectConfigDa.ChangeTeamDetails(lstTeam);
            }

            if (teamlead >0)
            {
                ProjectConfigDa.SetTeamLead(projectID, teamlead, secondTL);
            }
 
            return Json(pc, JsonRequestBehavior.AllowGet);
        }

    }
}