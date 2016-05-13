using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_ModulewiseVarianceMap : EntityTypeConfiguration<vw_ModulewiseVariance>
    {
        public vw_ModulewiseVarianceMap()
        {
            // Primary Key
            this.HasKey(t => t.ActualEfforts);

            // Properties
            this.Property(t => t.ModuleName)
                .HasMaxLength(100);

            this.Property(t => t.ActualEfforts)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectName)
                .HasMaxLength(551);

            // Table & Column Mappings
            this.ToTable("vw_ModulewiseVariance");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.PlannedEfforts).HasColumnName("PlannedEfforts");
            this.Property(t => t.ActualEfforts).HasColumnName("ActualEfforts");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.ProposedEstEfforts).HasColumnName("ProposedEstEfforts");
        }
    }
}
