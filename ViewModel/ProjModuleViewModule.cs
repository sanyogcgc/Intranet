using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class ProjModuleViewModule
    {
        public int? ProjModule_Id { get; set; }
        public string ModuleName { get; set; }
        public int? ProjectId { get; set; }
        public int? PhaseId { get; set; }
        public decimal? ModuleTime { get; set; }
    }
}
