using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjTaskMap : EntityTypeConfiguration<ProjTask>
    {
        public ProjTaskMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjTask_Id);

            // Properties
            this.Property(t => t.TaskName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ProjTask");
            this.Property(t => t.ProjTask_Id).HasColumnName("ProjTask_Id");
            this.Property(t => t.TaskName).HasColumnName("TaskName");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.Phase).HasColumnName("Phase");
            this.Property(t => t.BusinessUnitID).HasColumnName("BusinessUnitID");
            this.Property(t => t.ActiveFlag).HasColumnName("ActiveFlag");
        }
    }
}
