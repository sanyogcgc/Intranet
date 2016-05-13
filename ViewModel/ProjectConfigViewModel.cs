using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
 public   class ProjectConfigViewModel
    {
        public int ID { get; set; }

        public int Emp_Id { get; set; }

        public int? Units { get; set; }

        public int ProjectId { get; set; }

        public int? TeamLeader { get; set; }

        public string ManDays { get; set; }

        public int? Phaseid { get; set; }

        public string PhaseName { get; set; }

        public IEnumerable<ProjectViewModel> ProjectList { get; set; }
        [Required (ErrorMessage="Project Required.")]

        public ProjectViewModel SelectedProject { get; set; }

        public  IEnumerable<PhaseViewModel> phaseList  { get; set; }

        public string[] SelectedPhases { get; set; }

        public IEnumerable<TaskViewModel> taskList { get; set; }

        public string[] Selectedtasks { get; set; }

        public IEnumerable<UnitViewModel> unitList { get; set; }

        public UnitViewModel SelectedBusinessUnit { get; set; }

        public IEnumerable<EmployeeViewModel> EmployeeList { get; set; }

        public string[] SelectedEmployees { get; set; }

        public int? SelectedEmployeeTL { get; set; }

        public int? SelectedEmployeePM { get; set; }

        public decimal? ProposedEstEfforts { get; set; }

        public IEnumerable<ProjModuleViewModule> ProjModuleList { get; set; }

        public string[] SelectedModuleID { get; set; }

        public decimal? PlannedEfforts { get; set; }

        public int ModuleID { get; set; }

        public string  ModuleName { get; set; }

        public string ModuleTime { get; set; }

        public int TaskID { get; set; }

        public string TaskName { get; set; }

        public int TeamID { get; set; }

        public string  TeamName { get; set; }

        public int? TeamLeader_Second { get; set; }
   
    }
}
