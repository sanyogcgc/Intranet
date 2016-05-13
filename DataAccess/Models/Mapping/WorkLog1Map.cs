using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class WorkLog1Map : EntityTypeConfiguration<WorkLog1>
    {
        public WorkLog1Map()
        {
            // Primary Key
            this.HasKey(t => t.WorkLog_Id);

            // Properties
            this.Property(t => t.Comments)
                .HasMaxLength(2000);

            this.Property(t => t.Temp_Save)
                .HasMaxLength(10);

            this.Property(t => t.RMcomments)
                .HasMaxLength(1000);

            this.Property(t => t.Billable)
                .HasMaxLength(50);

            this.Property(t => t.Percentage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WorkLog1");
            this.Property(t => t.WorkLog_Id).HasColumnName("WorkLog_Id");
            this.Property(t => t.ForDate).HasColumnName("ForDate");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ProjId).HasColumnName("ProjId");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.TaskId).HasColumnName("TaskId");
            this.Property(t => t.ActivityId).HasColumnName("ActivityId");
            this.Property(t => t.SysDate).HasColumnName("SysDate");
            this.Property(t => t.SysTime).HasColumnName("SysTime");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Phase_Id).HasColumnName("Phase_Id");
            this.Property(t => t.Temp_Save).HasColumnName("Temp_Save");
            this.Property(t => t.UpdateCount).HasColumnName("UpdateCount");
            this.Property(t => t.RMcomments).HasColumnName("RMcomments");
            this.Property(t => t.Billable).HasColumnName("Billable");
            this.Property(t => t.Percentage).HasColumnName("Percentage");

            // Relationships
            this.HasOptional(t => t.ProjModule)
                .WithMany(t => t.WorkLog1)
                .HasForeignKey(d => d.ModuleId);

        }
    }
}
