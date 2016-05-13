using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCMaster
    {
        public int Audit_Id { get; set; }
        public Nullable<int> Sch_Audit_Quarter { get; set; }
        public Nullable<int> Sch_Audit_Year { get; set; }
        public Nullable<int> BU_Id { get; set; }
        public Nullable<int> Client_Id { get; set; }
        public Nullable<int> Project_Id { get; set; }
        public Nullable<int> Project_Leader { get; set; }
        public Nullable<int> Project_Type { get; set; }
        public Nullable<int> Project_Sub_Type { get; set; }
        public Nullable<int> Audit_Type { get; set; }
        public Nullable<int> Auditee_EmpId { get; set; }
        public Nullable<int> Auditor_EmpId { get; set; }
        public string Shadow_Auditors { get; set; }
        public Nullable<System.DateTime> Planned_Audit_Date { get; set; }
        public Nullable<System.DateTime> Actual_Audit_Date { get; set; }
        public Nullable<double> Planned_Efforts { get; set; }
        public Nullable<double> Actual_Efforts { get; set; }
        public string Agenda_Scope { get; set; }
        public string Comments { get; set; }
    }
}
