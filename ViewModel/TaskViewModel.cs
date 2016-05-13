using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
  public  class TaskViewModel
    {
        public int? ProjTask_Id { get; set; }
        public string TaskName { get; set; }   
       
        public int? ProjectId { get; set; }
        public int? Phase { get; set; }
        public int? BusinessUnitID { get; set; }
        public bool? ActiveFlag { get; set; }     
    }
}
