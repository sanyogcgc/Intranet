using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SecurityMap : EntityTypeConfiguration<Security>
    {
        public SecurityMap()
        {
            // Primary Key
            this.HasKey(t => t.security_id);

            // Properties
            this.Property(t => t.security_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(100);

            this.Property(t => t.description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Security");
            this.Property(t => t.security_id).HasColumnName("security_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
