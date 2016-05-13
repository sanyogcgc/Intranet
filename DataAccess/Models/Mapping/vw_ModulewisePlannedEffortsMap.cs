using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_ModulewisePlannedEffortsMap : EntityTypeConfiguration<vw_ModulewisePlannedEfforts>
    {
        public vw_ModulewisePlannedEffortsMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjModule_Id);

            // Properties
            this.Property(t => t.ModuleName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vw_ModulewisePlannedEfforts");
            this.Property(t => t.ProjModule_Id).HasColumnName("ProjModule_Id");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.PlannedEfforts).HasColumnName("PlannedEfforts");
        }
    }
}
