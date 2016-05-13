using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class bMap : EntityTypeConfiguration<b>
    {
        public bMap()
        {
            // Primary Key
            this.HasKey(t => t.bid);

            // Properties
            this.Property(t => t.category)
                .HasMaxLength(50);

            this.Property(t => t.subject)
                .HasMaxLength(50);

            this.Property(t => t.title)
                .HasMaxLength(50);

            this.Property(t => t.author)
                .HasMaxLength(50);

            this.Property(t => t.publisher)
                .HasMaxLength(50);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.place)
                .HasMaxLength(50);

            this.Property(t => t.status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("b");
            this.Property(t => t.bid).HasColumnName("bid");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.author).HasColumnName("author");
            this.Property(t => t.publisher).HasColumnName("publisher");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.place).HasColumnName("place");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
