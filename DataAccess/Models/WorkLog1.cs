using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("WorkLog1")]
    public partial class WorkLog1
    {
        [Key]
        public long WorkLog_Id { get; set; }

        public Nullable<System.DateTime> ForDate { get; set; }

        public Nullable<int> UserId { get; set; }

        public Nullable<int> ProjId { get; set; }

        public Nullable<decimal> Units { get; set; }

        public Nullable<int> ModuleId { get; set; }

        public Nullable<int> TaskId { get; set; }

        public Nullable<int> ActivityId { get; set; }

        public Nullable<System.DateTime> SysDate { get; set; }

        public Nullable<System.DateTime> SysTime { get; set; }

        public string Comments { get; set; }

        public Nullable<int> Phase_Id { get; set; }

        public string Temp_Save { get; set; }

        public Nullable<int> UpdateCount { get; set; }

        public string RMcomments { get; set; }

        public string Billable { get; set; }

        public string Percentage { get; set; }

        public virtual ProjModule ProjModule { get; set; }
    }
}
