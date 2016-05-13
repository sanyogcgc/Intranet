using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TarTypeMap : EntityTypeConfiguration<TarType>
    {
        public TarTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.type_id);

            // Properties
            this.Property(t => t.typename)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("TarType");
            this.Property(t => t.type_id).HasColumnName("type_id");
            this.Property(t => t.typename).HasColumnName("typename");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Intern).HasColumnName("Intern");
            this.Property(t => t.Extern).HasColumnName("Extern");
        }
    }
}
