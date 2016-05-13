using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class cdMap : EntityTypeConfiguration<cd>
    {
        public cdMap()
        {
            // Primary Key
            this.HasKey(t => t.cid);

            // Properties
            this.Property(t => t.category)
                .HasMaxLength(50);

            this.Property(t => t.title)
                .HasMaxLength(100);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.place)
                .HasMaxLength(50);

            this.Property(t => t.status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("cd");
            this.Property(t => t.cid).HasColumnName("cid");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.place).HasColumnName("place");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
