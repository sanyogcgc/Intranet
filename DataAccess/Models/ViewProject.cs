using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ViewProject
    {
        public Nullable<int> pTypeId { get; set; }
        public Nullable<int> pSubTypeId { get; set; }
        public Nullable<int> Unit_id { get; set; }
        public Nullable<int> PhaseId { get; set; }
        public string Project_Name { get; set; }
        public string Client_Name { get; set; }
        public int ID { get; set; }
        public string ProjectCode { get; set; }
        public string PhaseName { get; set; }
        public string Unit_name { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string spoc1 { get; set; }
        public string spoc2 { get; set; }
        public string am1 { get; set; }
        public string am2 { get; set; }
    }
}
