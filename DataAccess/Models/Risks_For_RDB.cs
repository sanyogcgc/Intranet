using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Risks_For_RDB
    {
        public string Risk_Id { get; set; }
        public string UnitId { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<System.DateTime> Identification_Date { get; set; }
        public Nullable<int> LikelihoodId { get; set; }
        public Nullable<int> ImpactId { get; set; }
        public string Measure { get; set; }
        public string R { get; set; }
        public string A { get; set; }
        public string C { get; set; }
        public string I { get; set; }
        public string Risk_Desc { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Expected_Impact { get; set; }
        public string Mitigation_Plan { get; set; }
        public string Backup_Plan { get; set; }
        public Nullable<System.DateTime> Due_Date { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Closure_Date { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public string AssociateProject { get; set; }
        public int TypeId { get; set; }
        public string UnitName { get; set; }
        public string SourceName { get; set; }
        public string LikelihoodName { get; set; }
        public string ImpactName { get; set; }
        public string TypeName { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public Nullable<int> StatusId { get; set; }
        public bool Show { get; set; }
        public string EmpName { get; set; }
        public Nullable<System.DateTime> ResolvedDate { get; set; }
        public Nullable<int> AssocProjId { get; set; }
        public Nullable<int> ResponsibleId { get; set; }
        public Nullable<int> AccountableId { get; set; }
        public Nullable<int> EmpId { get; set; }
        public string ActionTaken_Comments { get; set; }
    }
}
