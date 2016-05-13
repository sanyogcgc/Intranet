using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCDetail
    {
        public int Audit_Id { get; set; }
        public int Audit_SNo { get; set; }
        public string NC_Number { get; set; }
        public Nullable<System.DateTime> Audit_date { get; set; }
        public Nullable<int> NC_Type { get; set; }
        public int QMS_Process_Id { get; set; }
        public Nullable<int> CMMI_Process_Id { get; set; }
        public Nullable<int> Assigned_By_EmpId { get; set; }
        public Nullable<int> Assigned_To_EmpId { get; set; }
        public Nullable<int> Causes { get; set; }
        public Nullable<int> NC_Status { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Due_Date { get; set; }
        public Nullable<System.DateTime> Actual_Date { get; set; }
        public string CorPrev_Action { get; set; }
        public string Comments { get; set; }
        public Nullable<int> NoOfAttachments { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreationTS { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModificationTS { get; set; }
        public Nullable<int> NoOfModification { get; set; }
    }
}
