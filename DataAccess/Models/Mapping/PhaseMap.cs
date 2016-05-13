using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PhaseMap : EntityTypeConfiguration<Phase>
    {
        public PhaseMap()
        {
            // Primary Key
            this.HasKey(t => t.PhaseId);

            // Properties
            this.Property(t => t.PhaseName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Phase");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.PhaseName).HasColumnName("PhaseName");
            this.Property(t => t.BusinessUnitID).HasColumnName("BusinessUnitID");
            this.Property(t => t.ActiveFlag).HasColumnName("ActiveFlag");
        }
    }
}
