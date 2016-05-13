using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Idea
    {
        public int Idea_id { get; set; }
        public string Idea_category { get; set; }
        public string Idea_Name { get; set; }
        public string Details { get; set; }
        public string Doc_name { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public string Status { get; set; }
        public Nullable<int> Posted_By { get; set; }
        public Nullable<int> Posted_For { get; set; }
        public Nullable<int> Parent_Id { get; set; }
        public string HR_Comments { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public Nullable<int> Y { get; set; }
        public Nullable<int> N { get; set; }
        public string Eids { get; set; }
        public string Implement_Plan { get; set; }
        public Nullable<bool> Implemented { get; set; }
    }
}
