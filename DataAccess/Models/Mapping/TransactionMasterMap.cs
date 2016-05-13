using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TransactionMasterMap : EntityTypeConfiguration<TransactionMaster>
    {
        public TransactionMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionId);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(200);

            this.Property(t => t.Remarks)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("TransactionMaster");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.LeadId).HasColumnName("LeadId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.AssignTo).HasColumnName("AssignTo");
            this.Property(t => t.LeadAccept).HasColumnName("LeadAccept");
            this.Property(t => t.ReAssignTo).HasColumnName("ReAssignTo");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.DateTransaction).HasColumnName("DateTransaction");
            this.Property(t => t.TimeTransaction).HasColumnName("TimeTransaction");
        }
    }
}
