using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class directory_categoryMap : EntityTypeConfiguration<directory_category>
    {
        public directory_categoryMap()
        {
            // Primary Key
            this.HasKey(t => t.categoryid);

            // Properties
            this.Property(t => t.category)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("directory_category");
            this.Property(t => t.categoryid).HasColumnName("categoryid");
            this.Property(t => t.category).HasColumnName("category");
        }
    }
}
