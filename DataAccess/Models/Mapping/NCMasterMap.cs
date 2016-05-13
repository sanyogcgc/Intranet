using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCMasterMap : EntityTypeConfiguration<NCMaster>
    {
        public NCMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.Audit_Id);

            // Properties
            this.Property(t => t.Shadow_Auditors)
                .HasMaxLength(200);

            this.Property(t => t.Agenda_Scope)
                .HasMaxLength(200);

            this.Property(t => t.Comments)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("NCMaster");
            this.Property(t => t.Audit_Id).HasColumnName("Audit_Id");
            this.Property(t => t.Sch_Audit_Quarter).HasColumnName("Sch_Audit_Quarter");
            this.Property(t => t.Sch_Audit_Year).HasColumnName("Sch_Audit_Year");
            this.Property(t => t.BU_Id).HasColumnName("BU_Id");
            this.Property(t => t.Client_Id).HasColumnName("Client_Id");
            this.Property(t => t.Project_Id).HasColumnName("Project_Id");
            this.Property(t => t.Project_Leader).HasColumnName("Project_Leader");
            this.Property(t => t.Project_Type).HasColumnName("Project_Type");
            this.Property(t => t.Project_Sub_Type).HasColumnName("Project_Sub_Type");
            this.Property(t => t.Audit_Type).HasColumnName("Audit_Type");
            this.Property(t => t.Auditee_EmpId).HasColumnName("Auditee_EmpId");
            this.Property(t => t.Auditor_EmpId).HasColumnName("Auditor_EmpId");
            this.Property(t => t.Shadow_Auditors).HasColumnName("Shadow_Auditors");
            this.Property(t => t.Planned_Audit_Date).HasColumnName("Planned_Audit_Date");
            this.Property(t => t.Actual_Audit_Date).HasColumnName("Actual_Audit_Date");
            this.Property(t => t.Planned_Efforts).HasColumnName("Planned_Efforts");
            this.Property(t => t.Actual_Efforts).HasColumnName("Actual_Efforts");
            this.Property(t => t.Agenda_Scope).HasColumnName("Agenda_Scope");
            this.Property(t => t.Comments).HasColumnName("Comments");
        }
    }
}
