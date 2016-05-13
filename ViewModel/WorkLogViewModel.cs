using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class WorkLogViewModel
    {
        public string workLogDate{get;set;}
        public int Project_Id { get; set; }
        public int Phase_Id { get; set; }
        public int Module_id { get; set;}
        public int Task_id { get; set; }
        public double Time_spent { get; set; }
        public string Remarks { get; set;}
        public ProjectsViewModel SelectedProject { get; set; }
        public WorkLogDateViewModel SelectedDate { get; set; }
        public PhaseViewModel SelectedPhase { get; set; }
        public ModuleViewModel SelectedModule { get; set; }
        public TaskViewModel SelectedTask { get; set; }
        public TimeSpentViewModel SelectedTime { get; set; }
        public IEnumerable<ProjTaskViewModel> ProjTaskList { get; set; }
        public IEnumerable<WorkLogDateViewModel> WorkLogDayList { get; set; }
        public IEnumerable<ProjectsViewModel> ProjectsList { get; set; }
        public IEnumerable<PhaseViewModel> PhaseList { get; set; }
        public IEnumerable<ModuleViewModel> ModuleList { get; set; }
        public IEnumerable<TaskViewModel> TaskList { get; set; }
        public IEnumerable<TimeSpentViewModel> TimeSpentList { get; set; }
        public ActivityDetail Comment { get; set; }
        public List<ActivityDetail> CommentList { get; set; }
        public int RowIndex { get; set; }
    }
    public class ProjTaskViewModel
    {
        public int ProjTask_Id { get; set; }
        public string TaskName { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> Phase { get; set; }
        public Nullable<int> BusinessUnitID { get; set; }
        public Nullable<bool> ActiveFlag { get; set; }
    }
    public class TaskViewModel
    {
        public Nullable<int> ProjTask_Id { get; set; }
        public string TaskName { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> Phase { get; set; }
    }

    public class ModuleViewModel
    {
        public int ProjModule_Id { get; set; }
        public string ModuleName { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> PhaseId { get; set; }
    }
    public class PhaseViewModel
    {
        public Nullable<int> PhaseId { get; set; }
        public string PhaseName { get; set; }

        public int? Phaseid { get; set; }
    }
    public class TimeSpentViewModel
    {
        public string value {get;set;}
        public string text { get; set; }
    }

    public class WorkLogDateViewModel
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
    public class ProjectsViewModel
    {
        public int Project_ID { get; set; }
        public string Project_Name { get; set; }
    }
    public class ActivityDetail
    {
        public string Comments { get; set; }
    }
}
