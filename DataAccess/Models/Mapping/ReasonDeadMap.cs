using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ReasonDeadMap : EntityTypeConfiguration<ReasonDead>
    {
        public ReasonDeadMap()
        {
            // Primary Key
            this.HasKey(t => t.ReasonId);

            // Properties
            this.Property(t => t.ReasonId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ReasonDead");
            this.Property(t => t.ReasonId).HasColumnName("ReasonId");
            this.Property(t => t.Reason).HasColumnName("Reason");
        }
    }
}
