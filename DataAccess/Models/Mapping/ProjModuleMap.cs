using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjModuleMap : EntityTypeConfiguration<ProjModule>
    {
        public ProjModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjModule_Id);

            // Properties
            this.Property(t => t.ModuleName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ProjModule");
            this.Property(t => t.ProjModule_Id).HasColumnName("ProjModule_Id");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.ModuleTime).HasColumnName("ModuleTime");
        }
    }
}
