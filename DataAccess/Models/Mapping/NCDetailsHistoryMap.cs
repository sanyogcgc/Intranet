using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCDetailsHistoryMap : EntityTypeConfiguration<NCDetailsHistory>
    {
        public NCDetailsHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Audit_Id, t.Audit_SNo, t.NoOfChanges });

            // Properties
            this.Property(t => t.Audit_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Audit_SNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NC_Number)
                .HasMaxLength(35);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            this.Property(t => t.CorPrev_Action)
                .HasMaxLength(1000);

            this.Property(t => t.Comments)
                .HasMaxLength(1000);

            this.Property(t => t.NoOfChanges)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Operation)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("NCDetailsHistory");
            this.Property(t => t.Audit_Id).HasColumnName("Audit_Id");
            this.Property(t => t.Audit_SNo).HasColumnName("Audit_SNo");
            this.Property(t => t.NC_Number).HasColumnName("NC_Number");
            this.Property(t => t.Audit_date).HasColumnName("Audit_date");
            this.Property(t => t.NC_Type).HasColumnName("NC_Type");
            this.Property(t => t.QMS_Process_Id).HasColumnName("QMS_Process_Id");
            this.Property(t => t.CMMI_Process_Id).HasColumnName("CMMI_Process_Id");
            this.Property(t => t.Assigned_By_EmpId).HasColumnName("Assigned_By_EmpId");
            this.Property(t => t.Assigned_To_EmpId).HasColumnName("Assigned_To_EmpId");
            this.Property(t => t.Causes).HasColumnName("Causes");
            this.Property(t => t.NC_Status).HasColumnName("NC_Status");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Due_Date).HasColumnName("Due_Date");
            this.Property(t => t.Actual_Date).HasColumnName("Actual_Date");
            this.Property(t => t.CorPrev_Action).HasColumnName("CorPrev_Action");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.NoOfAttachments).HasColumnName("NoOfAttachments");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTS).HasColumnName("CreationTS");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModificationTS).HasColumnName("ModificationTS");
            this.Property(t => t.NoOfModification).HasColumnName("NoOfModification");
            this.Property(t => t.NoOfChanges).HasColumnName("NoOfChanges");
            this.Property(t => t.Operation).HasColumnName("Operation");
        }
    }
}
