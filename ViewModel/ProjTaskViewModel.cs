using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
     public class ProjTaskViewModel
    {
             public int ProjTask_Id { get; set; }
             public string TaskName { get; set; }
             public Nullable<int> ProjectId { get; set; }
             public Nullable<int> Phase { get; set; }
             public Nullable<int> BusinessUnitID { get; set; }
             public Nullable<bool> ActiveFlag { get; set; }
             //public IEnumerable<string> ProjectTaskList {get;set;}
             public ProjectViewModel SelectedProject { get; set; }
             public IEnumerable<ProjectViewModel> ProjectList { get; set; }
    }
}
