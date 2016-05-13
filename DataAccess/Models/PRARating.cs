using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PRARating
    {
        public int PRA_Id { get; set; }
        public int Emp_id { get; set; }
        public int MonthId { get; set; }
        public Nullable<double> April { get; set; }
        public Nullable<double> May { get; set; }
        public Nullable<double> June { get; set; }
        public Nullable<double> July { get; set; }
        public Nullable<double> August { get; set; }
        public Nullable<double> September { get; set; }
        public Nullable<double> October { get; set; }
        public Nullable<double> November { get; set; }
        public Nullable<double> December { get; set; }
        public Nullable<double> January { get; set; }
        public Nullable<double> February { get; set; }
        public Nullable<double> March { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int Quarter { get; set; }
        public string Awards { get; set; }
    }
}
