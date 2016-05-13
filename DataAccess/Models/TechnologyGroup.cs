using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public partial class TechnologyGroup
    {
      public int Id { get; set; }

      public string Technology_Name { get; set; }

      public bool Status { get; set; }

    }
}
