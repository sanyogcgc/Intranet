using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjMilestoneMap : EntityTypeConfiguration<ProjMilestone>
    {
        public ProjMilestoneMap()
        {
            // Primary Key
            this.HasKey(t => t.MilID);

            // Properties
            this.Property(t => t.MilName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ProjMilestones");
            this.Property(t => t.MilID).HasColumnName("MilID");
            this.Property(t => t.PID).HasColumnName("PID");
            this.Property(t => t.MilName).HasColumnName("MilName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
        }
    }
}
