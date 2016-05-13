using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Respons
    {
        public int Response_Id { get; set; }
        public Nullable<int> Issue_Id { get; set; }
        public string Response { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> type_id { get; set; }
        public Nullable<int> priority_id { get; set; }
        public int status_id { get; set; }
        public Nullable<int> Assigned_to { get; set; }
        public Nullable<System.DateTime> date_response { get; set; }
        public Nullable<double> Hours_Spent { get; set; }
        public Nullable<double> Hours_Allocated { get; set; }
        public string Altname { get; set; }
        public string version { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
    }
}
