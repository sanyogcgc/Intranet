using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ModuleMap : EntityTypeConfiguration<Module>
    {
        public ModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.Module_Id);

            // Properties
            this.Property(t => t.Module_Name)
                .HasMaxLength(100);

            this.Property(t => t.Module_Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Module");
            this.Property(t => t.Module_Id).HasColumnName("Module_Id");
            this.Property(t => t.Module_Name).HasColumnName("Module_Name");
            this.Property(t => t.Module_Description).HasColumnName("Module_Description");
            this.Property(t => t.Project_Id).HasColumnName("Project_Id");
        }
    }
}
