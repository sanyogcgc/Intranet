using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjTaskMapingMap : EntityTypeConfiguration<ProjTaskMaping>
    {
        public ProjTaskMapingMap()
        {
            // Primary Key
            this.HasKey(t => t.slNo);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProjTaskMaping");
            this.Property(t => t.slNo).HasColumnName("slNo");
            this.Property(t => t.projId).HasColumnName("projId");
            this.Property(t => t.taskId).HasColumnName("taskId");
            this.Property(t => t.orderIndex).HasColumnName("orderIndex");
        }
    }
}
