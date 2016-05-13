using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class GroupCategoryMap : EntityTypeConfiguration<GroupCategory>
    {
        public GroupCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.CategoryId);

            // Properties
            this.Property(t => t.Category)
                .HasMaxLength(50);

            this.Property(t => t.CatHeademailID)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("GroupCategory");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.CatHeadID).HasColumnName("CatHeadID");
            this.Property(t => t.CatHeademailID).HasColumnName("CatHeademailID");
        }
    }
}
