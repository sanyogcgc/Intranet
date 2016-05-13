using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SkillSubCategoryMap : EntityTypeConfiguration<SkillSubCategory>
    {
        public SkillSubCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillSubCatId);

            // Properties
            this.Property(t => t.SubCategory)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SkillSubCategory");
            this.Property(t => t.SkillSubCatId).HasColumnName("SkillSubCatId");
            this.Property(t => t.SkillCatId).HasColumnName("SkillCatId");
            this.Property(t => t.SubCategory).HasColumnName("SubCategory");
        }
    }
}
