using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.category_id);

            // Properties
            this.Property(t => t.category_desc)
                .HasMaxLength(100);

            this.Property(t => t.description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Categories");
            this.Property(t => t.category_id).HasColumnName("category_id");
            this.Property(t => t.category_desc).HasColumnName("category_desc");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.cat_order).HasColumnName("cat_order");
        }
    }
}
