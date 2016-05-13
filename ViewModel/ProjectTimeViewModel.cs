using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
  public class ProjectTimeViewModel
    {
        public int Sno { get; set; }
        public int Pid { get; set; }
        public int PhaseId { get; set; }
        public int SubPhaseId { get; set; }
        public int ManDays { get; set; }
        public string Remarks { get; set; }
    }
}
