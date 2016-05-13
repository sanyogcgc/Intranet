using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjectTimeMap : EntityTypeConfiguration<ProjectTime>
    {
        public ProjectTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.sno);

            // Properties
            this.Property(t => t.ManDays)
                .HasMaxLength(50);

            this.Property(t => t.Remarks)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ProjectTime");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.phaseid).HasColumnName("phaseid");
            this.Property(t => t.subphaseid).HasColumnName("subphaseid");
            this.Property(t => t.ManDays).HasColumnName("ManDays");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
        }
    }
}
