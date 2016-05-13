using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Issue
    {
        public int issue_id { get; set; }
        public string issue_name { get; set; }
        public string issue_desc { get; set; }
        public Nullable<int> user_id { get; set; }
        public int priority_id { get; set; }
        public int status_id { get; set; }
        public string version { get; set; }
        public Nullable<int> assigned_to { get; set; }
        public Nullable<int> assigned_to_orig { get; set; }
        public Nullable<System.DateTime> date_submitted { get; set; }
        public Nullable<System.DateTime> date_resolved { get; set; }
        public Nullable<System.DateTime> date_modified { get; set; }
        public Nullable<int> modified_by { get; set; }
        public string project_code { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public Nullable<double> hours_allocated { get; set; }
        public Nullable<decimal> category_id { get; set; }
        public Nullable<decimal> type_id { get; set; }
        public string Created_By { get; set; }
        public string Client_See { get; set; }
        public string Altname { get; set; }
    }
}
