using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class AcceptanceMap : EntityTypeConfiguration<Acceptance>
    {
        public AcceptanceMap()
        {
            // Primary Key
            this.HasKey(t => t.AcceptanceId);

            // Properties
            this.Property(t => t.Acceptance1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Acceptance");
            this.Property(t => t.Acceptance1).HasColumnName("Acceptance");
            this.Property(t => t.AcceptanceId).HasColumnName("AcceptanceId");
        }
    }
}
