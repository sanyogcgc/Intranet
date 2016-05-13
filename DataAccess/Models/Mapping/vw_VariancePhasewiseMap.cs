using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_VariancePhasewiseMap : EntityTypeConfiguration<vw_VariancePhasewise>
    {
        public vw_VariancePhasewiseMap()
        {
            // Primary Key
            this.HasKey(t => t.ActualEfforts);

            // Properties
            this.Property(t => t.PhaseName)
                .HasMaxLength(50);

            this.Property(t => t.ActualEfforts)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Remarks)
                .HasMaxLength(100);

            this.Property(t => t.ProjectName)
                .HasMaxLength(551);

            // Table & Column Mappings
            this.ToTable("vw_VariancePhasewise");
            this.Property(t => t.PhaseName).HasColumnName("PhaseName");
            this.Property(t => t.PlannedEfforts).HasColumnName("PlannedEfforts");
            this.Property(t => t.ActualEfforts).HasColumnName("ActualEfforts");
            this.Property(t => t.phaseid).HasColumnName("phaseid");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.ProjId).HasColumnName("ProjId");
            this.Property(t => t.ProposedEstEfforts).HasColumnName("ProposedEstEfforts");
        }
    }
}
