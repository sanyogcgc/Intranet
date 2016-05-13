using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
  public partial  class ResourceConfiguration
    {
      public int Id { get; set; }
      public int ProjectId { get; set; }
      public Nullable<System.DateTime> StartDate { get; set; }
      public Nullable<System.DateTime> EndTime { get; set; }
      public double Allocation { get; set; }
      public int   EmpID { get; set; }
      public Nullable<System.DateTime> CreatedOn { get; set; }
      public int CreatedBy { get; set; }
      public Nullable<System.DateTime> ModifiedOn { get; set; }
      public int? ModifiedBy { get; set; }
      public Boolean Status { get; set; }
      
    }
}
