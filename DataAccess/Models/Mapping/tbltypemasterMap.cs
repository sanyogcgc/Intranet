using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tbltypemasterMap : EntityTypeConfiguration<tbltypemaster>
    {
        public tbltypemasterMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeId);

            // Properties
            this.Property(t => t.TypeName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tbltypemaster");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
