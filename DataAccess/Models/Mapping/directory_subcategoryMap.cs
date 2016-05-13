using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class directory_subcategoryMap : EntityTypeConfiguration<directory_subcategory>
    {
        public directory_subcategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.subcategoryid);

            // Properties
            this.Property(t => t.subcategory)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("directory_subcategory");
            this.Property(t => t.subcategoryid).HasColumnName("subcategoryid");
            this.Property(t => t.categoryid).HasColumnName("categoryid");
            this.Property(t => t.subcategory).HasColumnName("subcategory");
        }
    }
}
