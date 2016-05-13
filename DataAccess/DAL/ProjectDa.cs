using DataAccess.Models;
using DataAccess.Models.Mapping;
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
    public class ProjectDa : BaseDa
    {
        public ProjectDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {
        }
        public IEnumerable<ProjectViewModel> GetProjects(int unitId, int teamLeader)
        {
            var result =
                             (from ep in UnitOfWork.ClientRepository.GetQuery()
                              join e in UnitOfWork.ProjectRepository.GetQuery() on ep.ID equals e.Client_Code
                              join t in UnitOfWork.ProjMemberRepository.GetQuery() on e.ID equals t.ProjectId
                              where e.Units == unitId && (e.teamLeader == teamLeader || e.TeamLeader_Second == teamLeader) && (e.ProjectCode != null || e.ProjStatus == 1)
                              orderby e.Project_Name
                              select new ProjectViewModel()
                              {
                                  ID = e.ID,
                                  ClientProject = ep.Client_Name + "/" + e.Project_Name,
                                  Units = e.Units,
                                  TeamLeader = e.teamLeader,
                                  IsBillable = e.IsBillable
                              }).Distinct().ToList();
            return result;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// GetTechnologyList for ResourceConfiguration
        public IEnumerable<TechnologyGroupViewModel> GetTechnologyList()
        {
            var model = new ResourceConfigurationViewModel();
            var result = UnitOfWork.TechnologyGroupRepository.Get().ToList();
            model.TechnologyGroupList = result.ToList().Select(x => new TechnologyGroupViewModel() {Id = x.Id,Technology_Name = x.Technology_Name });
            return model.TechnologyGroupList;
        }
        ////GetEmployee detail from Technology
        public IEnumerable<EmployeeDetailViewModel> GetEmployeeFromTechnology(int technologyid)
        {
            var result = (from emp in UnitOfWork.EmployeeRepository.GetQuery()
                          where emp.Technology_ID == technologyid
                          orderby emp.Fname
                          select new EmployeeDetailViewModel { 
                            Emp_Id = emp.Emp_id,
                            EmpName=  emp.Fname +" "+ emp.Mname+ " " + emp.Lname
                          }
                              ).ToList();
            return result;
        }
        /////GetResourceconfigureList
        public IEnumerable<ResourceConfigurationViewModel> GetResourceList(int rscid)
        {
            var result = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                          join proj in UnitOfWork.ProjectRepository.GetQuery ()
                          on emp.ProjectId equals proj.ID
                          where emp.EmpID == rscid && emp.EndTime > DateTime.Now
                          orderby proj.Project_Name
                          select new ResourceConfigurationViewModel 
                          {
                            Id = emp.Id,
                            ProjectId = emp.ProjectId,
                            ProjName = proj.Project_Name,
                            StartDate = (emp.StartDate),
                            EndTime  = (emp.EndTime),
                            Allocation = emp.Allocation,
                            EmpID = emp.EmpID
                          }
                              ).ToList();
            return result;
        }
        ////GetProjectsName
        /// <summary>
        /// /GetProjectName
        public IEnumerable<ProjectsViewModel> GetProject()
        {
            var result = (from proj in UnitOfWork.ProjectRepository.GetQuery() select new ProjectsViewModel { Project_ID = proj.ID, Project_Name = proj.Project_Name }).Distinct().ToList();
            return result;
        }

        

        /// </summary>
        /// <param name="teammember"></param>
        /// <returns></returns>
        public IEnumerable<ProjectsViewModel> GetWorkLogProjectsName(int teammember)
        {
               var result = (from emp in UnitOfWork.EmployeeRepository.GetQuery()
                              join pm in UnitOfWork.ProjMemberRepository.GetQuery() on emp.Emp_id equals pm.TeamMember
                              join proj in UnitOfWork.ProjectRepository.GetQuery() on pm.ProjectId equals proj.ID
                              where emp.Emp_id == teammember && proj.ProjStatus == 1
                              orderby proj.Project_Name
                              select new ProjectsViewModel
                              {
                                  Project_ID = proj.ID,
                                  Project_Name = proj.Project_Name
                              }
                                  ).Distinct().ToList();
               return result;
        }


        /////WorkLogPhaseList
        public IEnumerable<PhaseViewModel> GetWorkLogPhaseListData(int unitId)
        {
            var result = (from ph in UnitOfWork.PhaseRepository.GetQuery()
                          where ph.BusinessUnitID == unitId && ph.ActiveFlag == true
                          orderby ph.PhaseName
                          select new PhaseViewModel { 
                            PhaseId = ph.PhaseId,
                            PhaseName = ph.PhaseName
                          }
                              ).Distinct().ToList();
            return result;
        }

        
        ///WorkLogModuleList
        public IEnumerable<ModuleViewModel> GetWorkLogModuleListData(int teammember, int projectid)
        {
            var result = (from emp in UnitOfWork.EmployeeRepository.GetQuery()
                          join pm in UnitOfWork.ProjMemberRepository.GetQuery() on emp.Emp_id equals pm.TeamMember
                          join projm in UnitOfWork.ProjModuleRepository.GetQuery() on pm.ProjectId equals projm.ProjectId
                          where emp.Emp_id == teammember && pm.ProjectId == projectid
                          select new ModuleViewModel { 
                            ProjModule_Id = projm.ProjModule_Id,
                            ModuleName = projm.ModuleName
                          }
                              ).Distinct().ToList();
            return result;
        }

        ///GetworkProjTaskList
        public IEnumerable<ProjTaskViewModel> GetWorkLogProjTaskList(int teammember,int unitId,int projectid)
        {
            var result = (from emp in UnitOfWork.EmployeeRepository.GetQuery()
                          join pm in UnitOfWork.ProjMemberRepository.GetQuery() on emp.Emp_id equals pm.TeamMember
                          join projt in UnitOfWork.ProjTaskRepository.GetQuery() on pm.ProjectId equals projt.ProjectId
                          where emp.Emp_id == teammember && emp.Unit == unitId && pm.ProjectId == projectid 
                          select new ProjTaskViewModel
                          {
                              ProjTask_Id = projt.ProjTask_Id,
                              TaskName = projt.TaskName
                          }
                            ).Distinct().ToList();

            return result;
        }
        
        //   GetProjecTask
        public IEnumerable<ProjTaskViewModel> GetProjectName()
        {
            WorkLogViewModel wlVM = new WorkLogViewModel();
            var result = (from pt in UnitOfWork.ProjTaskRepository.GetQuery()
                          select new ProjTaskViewModel()
                          {
                              ProjTask_Id = pt.ProjTask_Id,
                              TaskName = pt.TaskName,
                          }).ToList();
            //wlVM.ProjTaskList = result;
            return result;
        }
        ///PostworkLogData
        public int InsertWorkLogData(List<WorkLogViewModel> WL,int CurrentUser)
        {
            try
            {
                UnitOfWork.WorkLog1Repository.BulkInsert(WL.ToList().Select(x => new WorkLog1() {UserId = CurrentUser, ProjId = x.Project_Id, Phase_Id = x.Phase_Id, ModuleId = x.Module_id, TaskId = x.Task_id, Comments = x.Remarks, Units = Convert.ToDecimal(x.Time_spent), SysDate = System.DateTime.Now }).ToList());
                UnitOfWork.WorkLog1Repository.context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                throw;
            }
        }
        ////PostResourceConfiguration Data
        public int SaveResourceConfigurationData(List<ResourceConfigurationViewModel> RcL, int prevRscID,int Userid)
        {
            try
            {
                UnitOfWork.ResourceConfigurationRepository.BulkInsert(RcL.ToList().Select(x => new ResourceConfiguration() { ProjectId = x.ProjectId, EmpID = x.EmpID, Allocation = x.Allocation, StartDate = x.StartDate, EndTime = x.EndTime, CreatedBy = Userid, CreatedOn = System.DateTime.Now, Status = true }).ToList());
                UnitOfWork.ResourceConfigurationRepository.context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        ////Update ResourceConfiguration Data
        public int UpdateResourceConfigurationData(List<ResourceConfigurationViewModel> RcL, int prevRscID, int Userid)
        {
            try
            {
                foreach (var item in RcL.ToList())
                {
                  
                    ResourceConfiguration ru = new ResourceConfiguration();
                    ru = UnitOfWork.ResourceConfigurationRepository.GetQuery().ToList().FirstOrDefault(x => x.Id == item.Id);
                    ru.StartDate = item.StartDate;
                    ru.EndTime = item.EndTime;
                    ru.Allocation = item.Allocation;
                    ru.ModifiedOn = System.DateTime.Now;
                   ru.ModifiedBy = Userid;
                    ru.ProjectId = item.ProjectId;
                    UnitOfWork.ResourceConfigurationRepository.Update(ru);
                    UnitOfWork.Save();
                    // }
                }
              //  UnitOfWork.ResourceConfigurationRepository.context.SaveChanges();
                return 2;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<ResourceConfigurationViewModel> GetResourcebyID(int rscid)
        {
            var result = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                          join proj in UnitOfWork.ProjectRepository.GetQuery()
                          on emp.ProjectId equals proj.ID
                          where emp.Id == rscid 
                          join e in UnitOfWork.EmployeeRepository.GetQuery()
                          on emp.EmpID equals e.Emp_id
                          orderby proj.Project_Name
                          select new ResourceConfigurationViewModel
                          {
                              Id = emp.Id,
                              ProjectId = emp.ProjectId,
                              ProjName = proj.Project_Name,
                              StartDate = (emp.StartDate),
                              EndTime = (emp.EndTime),
                              Allocation = emp.Allocation,
                              EmpID = emp.EmpID,
                              empName= e.Fname+ " " + e.Lname,
                          }
                              ).ToList();
            return result;
        }

        /////GetResourceconfigureList Technology wise
        public IEnumerable<ResourceConfigurationViewModel> GetResourceListAll(int UnitId, int? RourceId)
        {
            IEnumerable<ResourceConfigurationViewModel> empAllocat ;//= new IEnumerable<ResourceConfigurationViewModel>();
           empAllocat = null;

           // var empAllocation;
            if (RourceId == null)
            {
                var empAllocation = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                                     join proj in UnitOfWork.ProjectRepository.GetQuery()
                                      on emp.ProjectId equals proj.ID
                                     join empy in UnitOfWork.EmployeeRepository.GetQuery()
                                     on emp.EmpID equals empy.Emp_id
                                     where empy.Technology_ID == UnitId && emp.EndTime > DateTime.Now// && (emp.EmpID == RourceId || emp.EmpID == null)
                                     group emp by emp.EmpID into grouped
                                     select new
                                     {
                                         //  Emp_Id = grouped.Key.e == null ? 0 : g.Key.UserId,
                                         Emp_Id = grouped.Key,
                                         allocation = grouped.Sum(x => x.Allocation),
                                         endtime = grouped.Max(x => x.EndTime)
                                     });

                var result = (from empy in UnitOfWork.EmployeeRepository.GetQuery()
                              join emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                               on empy.Emp_id equals emp.EmpID
                              //join proj in UnitOfWork.ProjectRepository.GetQuery()
                              // on emp.ProjectId equals proj.ID 
                              join ll in empAllocation
                              on emp.EmpID equals ll.Emp_Id
                              where empy.Technology_ID == UnitId && emp.EndTime > DateTime.Now


                              select new ResourceConfigurationViewModel
                              {

                                  //    Id = emp.Id,
                                  //   ProjectId = emp.ProjectId,
                                  //  ProjName = proj.Project_Name,
                                  //  StartDate = (emp.StartDate),
                                  EndTime = (ll.endtime),

                                  EmpID = empy.Emp_id,
                                  Allocation = ll.allocation,
                                  empName = empy.Fname + " " + empy.Lname,
                              }).Distinct().ToList();

                result.Select(o => o.EmpID).Distinct();
                empAllocat = result;
                return empAllocat;
            }
            if (RourceId != null)
            {
                var empAllocation = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                                     join proj in UnitOfWork.ProjectRepository.GetQuery()
                                      on emp.ProjectId equals proj.ID
                                     join empy in UnitOfWork.EmployeeRepository.GetQuery()
                                     on emp.EmpID equals empy.Emp_id
                                     where empy.Technology_ID == UnitId && emp.EndTime > DateTime.Now && (emp.EmpID == RourceId)
                                     group emp by emp.EmpID into grouped
                                     select new
                                     {
                                         //  Emp_Id = grouped.Key.e == null ? 0 : g.Key.UserId,
                                         Emp_Id = grouped.Key,
                                         allocation = grouped.Sum(x => x.Allocation),
                                         endtime = grouped.Max(x => x.EndTime)
                                     });

                var result = (from empy in UnitOfWork.EmployeeRepository.GetQuery()
                              join emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                               on empy.Emp_id equals emp.EmpID
                              //join proj in UnitOfWork.ProjectRepository.GetQuery()
                              // on emp.ProjectId equals proj.ID 
                              join ll in empAllocation
                              on emp.EmpID equals ll.Emp_Id
                              where empy.Technology_ID == UnitId && emp.EndTime > DateTime.Now


                              select new ResourceConfigurationViewModel
                              {

                                  //    Id = emp.Id,
                                  //   ProjectId = emp.ProjectId,
                                  //  ProjName = proj.Project_Name,
                                  //  StartDate = (emp.StartDate),
                                  EndTime = (ll.endtime),

                                  EmpID = empy.Emp_id,
                                  Allocation = ll.allocation,
                                  empName = empy.Fname + " " + empy.Lname,


                              }).Distinct().ToList();

                result.Select(o => o.EmpID).Distinct();
                empAllocat = result;
                return result;
            }
            return empAllocat;

        }

        //Get data Within particular dates
        public IEnumerable<ResourceConfigurationViewModel> GetResourceListDatewise(int UnitId, int? RourceId, DateTime? FromDate, DateTime? ToDate)
        {
            IEnumerable<ResourceConfigurationViewModel> empAllocat;//= new IEnumerable<ResourceConfigurationViewModel>();
            empAllocat = null;

            // var empAllocation;
            if (RourceId == null)
            {
                var empAllocation = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                                     join proj in UnitOfWork.ProjectRepository.GetQuery()
                                      on emp.ProjectId equals proj.ID
                                     join empy in UnitOfWork.EmployeeRepository.GetQuery()
                                     on emp.EmpID equals empy.Emp_id
                                   
                                     where empy.Technology_ID == UnitId && emp.EndTime >= FromDate && emp.EndTime <= ToDate// && (emp.EmpID == RourceId || emp.EmpID == null)
                                     group emp by emp.EmpID into grouped
                                     select new
                                     {
                                         //  Emp_Id = grouped.Key.e == null ? 0 : g.Key.UserId,
                                         Emp_Id = grouped.Key,
                                         allocation = grouped.Sum(x => x.Allocation),
                                         endtime = grouped.Max(x => x.EndTime),
                                         
                                     });

                var result = (from empy in UnitOfWork.EmployeeRepository.GetQuery()
                              join emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                               on empy.Emp_id equals emp.EmpID
                              join tech in UnitOfWork.TechnologyGroupRepository.GetQuery()
                                  on empy.Technology_ID equals tech.Id
                              join m in UnitOfWork.EmployeeRepository.GetQuery() on empy.supervisor equals m.Emp_id
                              //join proj in UnitOfWork.ProjectRepository.GetQuery()
                              // on emp.ProjectId equals proj.ID 
                              join ll in empAllocation
                              on emp.EmpID equals ll.Emp_Id
                              where empy.Technology_ID == UnitId && emp.EndTime > DateTime.Now


                              select new ResourceConfigurationViewModel
                              {

                                  //    Id = emp.Id,
                                  //   ProjectId = emp.ProjectId,
                                  //  ProjName = proj.Project_Name,
                                  //  StartDate = (emp.StartDate),
                                  EndTime = (ll.endtime),

                                  EmpID = empy.Emp_id,
                                  Allocation = ll.allocation,
                                  empName = empy.Fname + " " + empy.Lname,
                                  Technology_Name = tech.Technology_Name,
                                  ManagerName = m.Fname + " " + m.Mname + " " + m.Lname,
                              }).Distinct().ToList();

                result.Select(o => o.EmpID).Distinct();
                empAllocat = result;
                return empAllocat;
            }
            if (RourceId != null)
            {
                var empAllocation = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                                     join proj in UnitOfWork.ProjectRepository.GetQuery()
                                      on emp.ProjectId equals proj.ID
                                     join empy in UnitOfWork.EmployeeRepository.GetQuery()
                                     on emp.EmpID equals empy.Emp_id
                                 
                                     where empy.Technology_ID == UnitId && emp.EndTime >= FromDate && emp.EndTime <= ToDate && (emp.EmpID == RourceId)
                                     group emp by emp.EmpID into grouped
                                     select new
                                     {
                                         //  Emp_Id = grouped.Key.e == null ? 0 : g.Key.UserId,
                                         Emp_Id = grouped.Key,
                                         allocation = grouped.Sum(x => x.Allocation),
                                         endtime = grouped.Max(x => x.EndTime)
                                     });

                var result = (from empy in UnitOfWork.EmployeeRepository.GetQuery()
                              join emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                               on empy.Emp_id equals emp.EmpID
                              join tech in UnitOfWork.TechnologyGroupRepository.GetQuery()
                                on empy.Technology_ID equals tech.Id
                              join m in UnitOfWork.EmployeeRepository.GetQuery() on empy.supervisor equals m.Emp_id
                              //join proj in UnitOfWork.ProjectRepository.GetQuery()
                              // on emp.ProjectId equals proj.ID 
                              join ll in empAllocation
                              on emp.EmpID equals ll.Emp_Id
                              where empy.Technology_ID == UnitId && emp.EndTime > DateTime.Now


                              select new ResourceConfigurationViewModel
                              {

                                  //    Id = emp.Id,
                                  //   ProjectId = emp.ProjectId,
                                  //  ProjName = proj.Project_Name,
                                  //  StartDate = (emp.StartDate),
                                  EndTime = (ll.endtime),

                                  EmpID = empy.Emp_id,
                                  Allocation = ll.allocation,
                                  empName = empy.Fname + " " + empy.Lname,
                                  Technology_Name = tech.Technology_Name,
                                  ManagerName = m.Fname + " " + m.Mname + " " + m.Lname,

                              }).Distinct().ToList();

                result.Select(o => o.EmpID).Distinct();
                empAllocat = result;
                return result;
            }
            return empAllocat;

        }

        // Datewise subgriddata

        public IEnumerable<ResourceConfigurationViewModel> GetResourceDatewiseSubGrid(int rscid, DateTime? FromDate, DateTime? ToDate)
        {
            var result = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                          join proj in UnitOfWork.ProjectRepository.GetQuery()
                          on emp.ProjectId equals proj.ID
                          where emp.EmpID == rscid &&  emp.EndTime >= FromDate && emp.EndTime <= ToDate
                          orderby proj.Project_Name
                          select new ResourceConfigurationViewModel
                          {
                              Id = emp.Id,
                              ProjectId = emp.ProjectId,
                              ProjName = proj.Project_Name,
                              StartDate = (emp.StartDate),
                              EndTime = (emp.EndTime),
                              Allocation = emp.Allocation,
                              EmpID = emp.EmpID
                          }
                              ).ToList();
            return result;
        }


        public IEnumerable<ResourceConfigurationViewModel> GetResourceDatewiseDetails(int rscid, DateTime? FromDate, DateTime? ToDate)
        {
            var result = (from emp in UnitOfWork.ResourceConfigurationRepository.GetQuery()
                          join proj in UnitOfWork.ProjectRepository.GetQuery()
                          on emp.ProjectId equals proj.ID
                          join e in UnitOfWork.EmployeeRepository.GetQuery()
                          on emp.EmpID equals e.Emp_id
                          where e.Technology_ID == rscid && emp.EndTime >= FromDate && emp.EndTime <= ToDate
                          orderby proj.Project_Name
                          select new ResourceConfigurationViewModel
                          {
                              Id = emp.Id,
                              ProjectId = emp.ProjectId,
                              ProjName = proj.Project_Name,
                              StartDate = (emp.StartDate),
                              EndTime = (emp.EndTime),
                              Allocation = emp.Allocation,
                              EmpID = emp.EmpID,
                              empName= e.Fname + " " + e.Lname,
                          }
                              ).ToList();
            return result;
        }

    }
}