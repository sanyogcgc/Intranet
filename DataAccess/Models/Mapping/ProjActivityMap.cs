using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjActivityMap : EntityTypeConfiguration<ProjActivity>
    {
        public ProjActivityMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjActivity_Id);

            // Properties
            this.Property(t => t.ActivityName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ProjActivity");
            this.Property(t => t.ProjActivity_Id).HasColumnName("ProjActivity_Id");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.ActivityType).HasColumnName("ActivityType");
        }
    }
}
