using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
  public  class PhaseViewModel
    {
        public int? Phaseid { get; set; }

        public string PhaseName { get; set; }

        public int? BusinessUnitID { get; set; }

        public bool ActiveFlag { get; set; }
    }
}
