using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess.DAL
{
    public class ProjectConfigDa : BaseDa
    {
        public ProjectConfigDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        { }


        public IEnumerable<PhaseViewModel> GetPhase(int unitId)
        {
            var result = (from phse in UnitOfWork.PhaseRepository.GetQuery()
                          where phse.BusinessUnitID == unitId && phse.ActiveFlag == true
                          orderby phse.PhaseName
                          select new PhaseViewModel()
                         {
                             PhaseId = phse.PhaseId,
                             PhaseName = phse.PhaseName
                         }).Distinct().ToList();
            return result;
        }

        public IEnumerable<TaskViewModel> GetTask(int unitId)
        {
            var result = (from tsk in UnitOfWork.ProjTaskRepository.GetQuery()
                          where tsk.BusinessUnitID == unitId && tsk.ActiveFlag == true
                          orderby tsk.TaskName
                          select new TaskViewModel()
                          {
                              ProjTask_Id = tsk.ProjTask_Id,
                              TaskName = tsk.TaskName
                          }).Distinct().ToList();
            return result;
        }


        public IEnumerable<UnitViewModel> GetUnitBusiness()
        {
            var result = (from unt in UnitOfWork.UnitRepository.GetQuery()
                          where unt.flag == 1
                          orderby unt.Unit_name
                          select new UnitViewModel()
                          {
                              Unit_id = unt.Unit_id,
                              Unit_name = unt.Unit_name
                          }).Distinct().ToList();
            return result;
        }

        public IEnumerable<EmployeeViewModel> GetAllEmployee()
        {
            var result = (from e in UnitOfWork.EmployeeRepository.GetQuery()
                          where e.Status == "Current"
                          orderby e.Fname
                          select new EmployeeViewModel()
                          {
                              Emp_Id = e.Emp_id,
                              EmployeeName = e.Fname + " " + e.Mname + " " + e.Lname,
                          }).Distinct().ToList();
            return result;
        }
        public ProjectConfigViewModel GetProposedEstEfforts(int projectId)
        {
            var ProposedEstEfforts = (from e in UnitOfWork.ProjectRepository.GetQuery()
                                      where e.ID == projectId
                                      select new ProjectConfigViewModel()
                                      {
                                          ProposedEstEfforts = e.ProposedEstEfforts,

                                      }).Distinct().SingleOrDefault();

            return ProposedEstEfforts;
        }

        public IEnumerable<PhaseViewModel> GetPhaseTimeProjectWise(int projectId)
        {
            var Phase = (from t in UnitOfWork.ProjectTimeRepository.GetQuery()
                         join p in UnitOfWork.PhaseRepository.GetQuery()
                         on t.phaseid equals p.PhaseId
                         where t.pid == projectId
                         select new PhaseViewModel()
                         {
                             Phaseid =t.phaseid,
                             PhaseName = p.PhaseName + ":" + t.ManDays,
                         }).Distinct().ToList();
            return Phase;
        }

        public IEnumerable<ProjModuleViewModule> GetModuleProjectWise(int projectId)
        {
            var Phase = (from t in UnitOfWork.ProjModuleRepository.GetQuery()
                         where t.ProjectId == projectId
                         orderby t.ProjModule_Id
                         select new ProjModuleViewModule()
                         {
                             ProjModule_Id = t.ProjModule_Id,
                             ModuleName = t.ModuleName + ": " + t.ModuleTime,
                             ModuleTime = t.ModuleTime,
                             PhaseId = t.PhaseId
                         }).Distinct().ToList();
            return Phase;
        }

        public IEnumerable<TaskViewModel> GetTaskProjectWise(int projectId)
        {
            var Phase = (from m in UnitOfWork.ProjTaskMapingRepository.GetQuery()
                         join y in UnitOfWork.ProjTaskRepository.GetQuery()
                             // join x in UnitOfWork.ProjTaskRepository.GetQuery
                         on m.taskId equals y.ProjTask_Id
                         where m.projId == projectId
                         orderby m.orderIndex
                         select new TaskViewModel()
                         {
                             ProjTask_Id = m.taskId,
                             TaskName = y.TaskName
                         }).Distinct().ToList();
            return Phase;
        }

        public IEnumerable<EmployeeViewModel> GetEmployeeProjectWise(int projectId)
        {
            var innerQuery = from fb in UnitOfWork.ProjMemberRepository.GetQuery() where fb.ProjectId == projectId select fb.TeamMember;

            var Phase = (from m in UnitOfWork.EmployeeRepository.GetQuery()
                         where m.Status == "Current" && innerQuery.Contains(m.Emp_id)
                         orderby m.Fname
                         select new EmployeeViewModel()
                         {
                             Emp_Id = m.Emp_id,
                             EmployeeName = m.Fname + " " + m.Mname + " " + m.Lname
                         }).Distinct().ToList();
            return Phase;
        }

        public int GetTeamLeaderProjectWise(int projectId, int unit)
        {
            ProjectConfigViewModel Phase = (from p in UnitOfWork.ProjectRepository.GetQuery()
                                            join e in UnitOfWork.EmployeeRepository.GetQuery()
                                            on p.teamLeader equals e.Emp_id
                                            where e.Status == "Current" && e.Unit == unit && p.ID == projectId
                                            select new ProjectConfigViewModel()
                                            {
                                                TeamLeader = p.teamLeader,
                                                TeamLeader_Second = p.TeamLeader_Second
                                            }).Distinct().FirstOrDefault();
            int? tl = Phase.TeamLeader;
            return Convert.ToInt32(tl);
        }

        public IEnumerable<EmployeeViewModel> GetEmployeeUnitWise(int unitID)
        {
            var Employee = (from e in UnitOfWork.EmployeeRepository.GetQuery()
                            where (unitID == 0 || e.Unit == unitID) && e.Status == "Current"
                            orderby e.Fname
                            select new EmployeeViewModel()
                              {
                                  Emp_Id = e.Emp_id,
                                  EmployeeName = e.Fname + " " + e.Mname + " " + e.Lname
                              }).Distinct().ToList();
            return Employee;
        }

        public int UpdateAllRecord(List<ProjectConfigViewModel> ProjectConfigViewModel)
        {


            #region --Phase--
            int projectID = ProjectConfigViewModel.FirstOrDefault().ProjectId;
            int i = 0;
            var ExistsDB = (from t in UnitOfWork.ProjectTimeRepository.GetQuery()
                            join p in UnitOfWork.PhaseRepository.GetQuery()
                            on t.phaseid equals p.PhaseId
                            where t.pid == projectID
                            select new PhaseViewModel()
                            {
                                Phaseid = t.phaseid
                            }).Distinct().ToList();
            //Delete
            var InDB = from item1 in ExistsDB
                       where !(ProjectConfigViewModel.Any(item2 => item2.Phaseid == item1.Phaseid))
                       select item1;
            List<ProjectTimeViewModel> lstFrDelete = new List<ProjectTimeViewModel>();
            foreach (var item in lstFrDelete)
            {
                //lstFrDelete.Insert(0,item.PhaseId);
            }
            //Insert
            var InLst = from item1 in ProjectConfigViewModel
                        where !(ExistsDB.Any(item2 => item2.Phaseid == item1.Phaseid))
                        select item1;
            //Update 
            var comman = from item1 in ProjectConfigViewModel
                         where (ExistsDB.Any(item2 => item2.Phaseid == item1.Phaseid))
                         select item1;


            ProjectTime ru = new ProjectTime();
            if (comman.Count() > 0)
            {
                foreach (var item in comman.ToList().Select(x => new ProjectTime() { pid = Convert.ToInt32(x.ProjectId), phaseid = Convert.ToInt32(x.Phaseid), ManDays = x.PhaseName }).ToList())
                {
                    //lst.ManDays
                    string ManDay = item.ManDays.Split(':').LastOrDefault();
                    // ResourceUtilization ru = new ResourceUtilization();
                    ru = UnitOfWork.ProjectTimeRepository.GetQuery().ToList().FirstOrDefault(x => x.pid == item.pid && x.phaseid == item.phaseid);
                    // ru.phaseid = item.phaseid;
                    ru.ManDays = ManDay;

                    UnitOfWork.ProjectTimeRepository.Update(ru);
                    UnitOfWork.ProjectTimeRepository.context.SaveChanges();
                    // }
                }
            }

            if (InLst.Count() > 0)
            {
                foreach (var item in InLst)
                {
                    // string PhaseName = item.ManDays.Split(':').FirstOrDefault();
                    if (item.PhaseName != null)
                    {
                        string Manday = item.PhaseName.Split(':').LastOrDefault();
                        item.ManDays = Manday;
                    }
                    // item.PhaseName = PhaseName;
                }
                UnitOfWork.ProjectTimeRepository.BulkInsert(InLst.ToList().Select(x => new ProjectTime() { pid = Convert.ToInt32(x.ProjectId), phaseid = Convert.ToInt32(x.Phaseid), ManDays = x.ManDays }).ToList());
                UnitOfWork.ResourceUtilizationRepository.context.SaveChanges();
            }

            if (InDB.Count() > 0)
            {
                foreach (var item in InDB.ToList().Select(x => new PhaseViewModel() { Phaseid = Convert.ToInt32(x.Phaseid) }).ToList())
                {
                    ru = UnitOfWork.ProjectTimeRepository.GetQuery().ToList().FirstOrDefault(x => x.pid == projectID && x.phaseid == item.Phaseid);
                    // var ru =   UnitOfWork.ProjectTimeRepository.Delete(InLst.ToList().Select(x => new ProjectTime() { pid = Convert.ToInt32(x.ProjectId), phaseid = Convert.ToInt32(x.Phaseid), ManDays = x.ManDays }).ToList());
                    UnitOfWork.ProjectTimeRepository.Delete(ru);
                    UnitOfWork.ProjectTimeRepository.context.SaveChanges();
                }
            }

            #endregion

            return i;
        }

        #region -- Module--

        public int ChangeModule(List<ProjectConfigViewModel> ProjectConfigViewModel)
        {
            int i = 0;
            int projectID = ProjectConfigViewModel.FirstOrDefault().ProjectId;
            var ModuleExistDB = (from t in UnitOfWork.ProjModuleRepository.GetQuery()
                                 where t.ProjectId == projectID
                                 orderby t.ProjModule_Id
                                 select new ProjModuleViewModule()
                                 {
                                     ProjModule_Id = t.ProjModule_Id,
                                     ModuleName = t.ModuleName,// + ": " + t.ModuleTime,
                                     ModuleTime = t.ModuleTime,
                                     PhaseId = t.PhaseId
                                 }).Distinct().ToList();


            //Delete
            var InDB = from item1 in ModuleExistDB
                       where !(ProjectConfigViewModel.Any(item2 => item2.ModuleID == item1.ProjModule_Id))
                       select item1;
            List<ProjectTimeViewModel> lstFrDelete = new List<ProjectTimeViewModel>();

            //Insert
            var InLst = from item1 in ProjectConfigViewModel
                        where !(ModuleExistDB.Any(item2 => item2.ProjModule_Id == item1.ModuleID))
                        select item1;
            //Update 
            var comman = from item1 in ProjectConfigViewModel
                         where (ModuleExistDB.Any(item2 => item2.ProjModule_Id == item1.ModuleID))
                         select item1;


            ProjModule ru = new ProjModule();
            if (comman.Count() > 0)
            {
                foreach (var item in comman.ToList().Select(x => new ProjModule() { ProjectId = Convert.ToInt32(x.ProjectId), ProjModule_Id = Convert.ToInt32(x.ModuleID), ModuleName = x.ModuleName }).ToList())
                {
                    //lst.ManDays
                    string ModuleTime = item.ModuleName.Split(':').LastOrDefault();
                    item.ModuleTime = Convert.ToDecimal(ModuleTime);
                    // ResourceUtilization ru = new ResourceUtilization();
                    ru = UnitOfWork.ProjModuleRepository.GetQuery().ToList().FirstOrDefault(x => x.ProjectId == item.ProjectId && x.ProjModule_Id == item.ProjModule_Id);
                    // ru.phaseid = item.phaseid;
                    ru.ModuleTime = item.ModuleTime;
                    UnitOfWork.ProjModuleRepository.Update(ru);
                    UnitOfWork.ProjModuleRepository.context.SaveChanges();
                    // }
                }
            }

            if (InLst.Count() > 0)
            {
                foreach (var item in InLst)
                {
                    // string PhaseName = item.ManDays.Split(':').FirstOrDefault();
                    string ModuleTime = item.ModuleName.Split(':').LastOrDefault();
                    // item.ModuleTime= ModuleTime;
                    item.ModuleTime = ModuleTime;
                    string ModuleName = item.ModuleName.Split(':').FirstOrDefault();
                    item.ModuleName = ModuleName;
                }
                UnitOfWork.ProjModuleRepository.BulkInsert(InLst.ToList().Select(x => new ProjModule() { ProjectId = Convert.ToInt32(x.ProjectId), ModuleName = x.ModuleName, ModuleTime = Convert.ToDecimal(x.ModuleTime) }).ToList());
                UnitOfWork.ResourceUtilizationRepository.context.SaveChanges();
            }

            if (InDB.Count() > 0)
            {
                foreach (var item in InDB.ToList().Select(x => new ProjModule() { ProjModule_Id = Convert.ToInt32(x.ProjModule_Id) }).ToList())
                {
                    ru = UnitOfWork.ProjModuleRepository.GetQuery().ToList().FirstOrDefault(x => x.ProjectId == projectID && x.ProjModule_Id == item.ProjModule_Id);
                    // var ru =   UnitOfWork.ProjectTimeRepository.Delete(InLst.ToList().Select(x => new ProjectTime() { pid = Convert.ToInt32(x.ProjectId), phaseid = Convert.ToInt32(x.Phaseid), ManDays = x.ManDays }).ToList());
                    UnitOfWork.ProjModuleRepository.Delete(ru);
                    UnitOfWork.ProjModuleRepository.context.SaveChanges();
                }
            }
            return i;
        }

        #endregion


        #region

        public int ChangeTaskDetails(List<ProjectConfigViewModel> ProjectConfigViewModel)
        {
            int i = 0;

            int projectID = ProjectConfigViewModel.FirstOrDefault().ProjectId;
            var TaskExistDB = (from m in UnitOfWork.ProjTaskMapingRepository.GetQuery()
                               join y in UnitOfWork.ProjTaskRepository.GetQuery()
                                   // join x in UnitOfWork.ProjTaskRepository.GetQuery
                               on m.taskId equals y.ProjTask_Id
                               where m.projId == projectID
                               orderby m.orderIndex
                               select new TaskViewModel()
                               {
                                   ProjTask_Id = m.taskId,
                                   TaskName = y.TaskName
                               }).Distinct().ToList();


            //Delete
            var InDB = from item1 in TaskExistDB
                       where !(ProjectConfigViewModel.Any(item2 => item2.TaskID == item1.ProjTask_Id))
                       select item1;
            List<ProjectTimeViewModel> lstFrDelete = new List<ProjectTimeViewModel>();

            //Insert
            var InLst = from item1 in ProjectConfigViewModel
                        where !(TaskExistDB.Any(item2 => item2.ProjTask_Id == item1.TaskID))
                        select item1;
            //Update 
            var comman = from item1 in ProjectConfigViewModel
                         where (TaskExistDB.Any(item2 => item2.ProjTask_Id == item1.TaskID))
                         select item1;


            ProjTaskMaping ru = new ProjTaskMaping();
            if (comman.Count() > 0)
            {
                foreach (var item in comman.ToList().Select(x => new ProjTaskMaping() { projId = Convert.ToInt32(x.ProjectId), taskId = Convert.ToInt32(x.TaskID) }).ToList())
                {
                    //lst.ManDays
                    //string ModuleTime = item.ModuleName.Split(':').LastOrDefault();
                    // item.ModuleTime = Convert.ToDecimal(ModuleTime);
                    // ResourceUtilization ru = new ResourceUtilization();
                    ru = UnitOfWork.ProjTaskMapingRepository.GetQuery().ToList().FirstOrDefault(x => x.projId == item.projId && x.taskId == item.taskId);
                    ru.taskId = item.taskId;
                    //ru.ProjTask_Id = item.ProjTask_Id;
                    // ru.TaskName = item.TaskName;
                    UnitOfWork.ProjTaskMapingRepository.Update(ru);
                    UnitOfWork.ProjTaskRepository.context.SaveChanges();
                    // }
                }
            }

            if (InLst.Count() > 0)
            {
                //foreach (var item in InLst)
                //{
                //    // string PhaseName = item.ManDays.Split(':').FirstOrDefault();
                //    //string ModuleTime = item.ModuleName.Split(':').LastOrDefault();
                //    // item.ModuleTime= ModuleTime;
                //   item.TaskID = ModuleTime;
                //   // string ModuleName = item.ModuleName.Split(':').FirstOrDefault();
                //    item.TaskName = item.TaskName;
                //}
                UnitOfWork.ProjTaskMapingRepository.BulkInsert(InLst.ToList().Select(x => new ProjTaskMaping() { projId = Convert.ToInt32(x.ProjectId), taskId = x.TaskID }).ToList());
                UnitOfWork.ResourceUtilizationRepository.context.SaveChanges();
            }

            if (InDB.Count() > 0)
            {
                foreach (var item in InDB.ToList().Select(x => new ProjTaskMaping() { projId = Convert.ToInt32(x.ProjectId), taskId = x.ProjTask_Id }).ToList())
                {
                    ru = UnitOfWork.ProjTaskMapingRepository.GetQuery().ToList().FirstOrDefault(x => x.projId == projectID && x.taskId == item.taskId);
                    // var ru =   UnitOfWork.ProjectTimeRepository.Delete(InLst.ToList().Select(x => new ProjectTime() { pid = Convert.ToInt32(x.ProjectId), phaseid = Convert.ToInt32(x.Phaseid), ManDays = x.ManDays }).ToList());
                    UnitOfWork.ProjTaskMapingRepository.Delete(ru);
                    UnitOfWork.Save();
                }
            }
            return i;
        }

        #endregion

        #region-- Team--

        public int ChangeTeamDetails(List<ProjectConfigViewModel> ProjectConfigViewModel)
        {
            int i = 0;

            int projectID = ProjectConfigViewModel.FirstOrDefault().ProjectId;
            var TeamExistDB = (from fb in UnitOfWork.ProjMemberRepository.GetQuery() where fb.ProjectId == projectID select fb.TeamMember).Distinct().ToList();

            //var TeamExistDB = (from m in UnitOfWork.EmployeeRepository.GetQuery()
            //             where m.Status == "Current" && innerQuery.Contains(m.Emp_id)
            //             orderby m.Fname
            //             select new EmployeeViewModel()
            //             {
            //                 Emp_Id = m.Emp_id,
            //                 EmployeeName = m.Fname + " " + m.Mname + " " + m.Lname
            //             }).Distinct().ToList();


            //Delete
            var InDB = from item1 in TeamExistDB
                       where !(ProjectConfigViewModel.Any(item2 => item2.TeamID == item1.Value))
                       select item1;
            //List<ProjectTimeViewModel> lstFrDelete = new List<ProjectTimeViewModel>();

            //Insert
            var InLst = from item1 in ProjectConfigViewModel
                        where !(TeamExistDB.Any(item2 => item2.Value == item1.TeamID))
                        select item1;
            //Update 
            var comman = from item1 in ProjectConfigViewModel
                         where (TeamExistDB.Any(item2 => item2.Value == item1.TeamID))
                         select item1;


            ProjMember ru = new ProjMember();
            if (comman.Count() > 0)
            {
                //foreach (var item in comman.ToList().Select(x => new ProjMember() { ProjectId = Convert.ToInt32(x.ProjectId), TeamMember = Convert.ToInt32(x.TeamID) }).ToList())
                //{
                //    //lst.ManDays
                //    //string ModuleTime = item.ModuleName.Split(':').LastOrDefault();
                //    // item.ModuleTime = Convert.ToDecimal(ModuleTime);
                //    // ResourceUtilization ru = new ResourceUtilization();
                //    ru = UnitOfWork.ProjMemberRepository.GetQuery().ToList().FirstOrDefault(x => x.ProjectId == item.ProjectId && x.TeamMember == item.TeamMember);
                //     ru.TeamMember = item.TeamMember;
                //    //ru.ProjTask_Id = item.ProjTask_Id;
                //    // ru.TaskName = item.TaskName;
                //     UnitOfWork.ProjMemberRepository.Update(ru);
                //    UnitOfWork.ProjTaskRepository.context.SaveChanges();
                //    // }
                //}
            }

            if (InLst.Count() > 0)
            {
                //foreach (var item in InLst)
                //{
                //    // string PhaseName = item.ManDays.Split(':').FirstOrDefault();
                //    //string ModuleTime = item.ModuleName.Split(':').LastOrDefault();
                //    // item.ModuleTime= ModuleTime;
                //   item.TaskID = ModuleTime;
                //   // string ModuleName = item.ModuleName.Split(':').FirstOrDefault();
                //    item.TaskName = item.TaskName;
                //}
                UnitOfWork.ProjMemberRepository.BulkInsert(InLst.ToList().Select(x => new ProjMember() { ProjectId = Convert.ToInt32(x.ProjectId), TeamMember = x.TeamID }).ToList());
                UnitOfWork.Save();

            }

            if (InDB.Count() > 0)
            {
                foreach (var item in InDB.ToList().Select(x => new ProjMember() { ProjectId = projectID, TeamMember = x.Value }).ToList())
                {
                    ru = UnitOfWork.ProjMemberRepository.GetQuery().ToList().FirstOrDefault(x => x.ProjectId == projectID && x.TeamMember == item.TeamMember);
                    // var ru =   UnitOfWork.ProjectTimeRepository.Delete(InLst.ToList().Select(x => new ProjectTime() { pid = Convert.ToInt32(x.ProjectId), phaseid = Convert.ToInt32(x.Phaseid), ManDays = x.ManDays }).ToList());
                    UnitOfWork.ProjMemberRepository.Delete(ru);
                    UnitOfWork.Save();
                }
            }
            return i;
        }
        #endregion

        public int SetTeamLead(int pid, int tl, int secondTL)
        {
            int i = 0;
            //lst.ManDays
            // string ModuleTime = item.ModuleName.Split(':').LastOrDefault();
            // item.ModuleTime = Convert.ToDecimal(ModuleTime);
            // ResourceUtilization ru = new ResourceUtilization();
            Project ru = new Project();
            ru = UnitOfWork.ProjectRepository.GetQuery().ToList().FirstOrDefault(x => x.ID == pid);
            // ru.phaseid = item.phaseid;
            ru.teamLeader = tl;
            if (secondTL>0)
            ru.TeamLeader_Second = secondTL;
            UnitOfWork.ProjectRepository.Update(ru);
            UnitOfWork.Save();

            return i;
        }
    }
}
