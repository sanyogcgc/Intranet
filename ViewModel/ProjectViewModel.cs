using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProjectViewModel
    {
        public int ID { get; set; }

        public string ClientProject { get; set; }

        public int? Units { get; set; }

        public int? TeamLeader { get; set; }

        public bool? IsBillable { get; set; }
    }
}