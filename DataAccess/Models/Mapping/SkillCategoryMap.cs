using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SkillCategoryMap : EntityTypeConfiguration<SkillCategory>
    {
        public SkillCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillCatId);

            // Properties
            this.Property(t => t.Category)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SkillCategory");
            this.Property(t => t.SkillCatId).HasColumnName("SkillCatId");
            this.Property(t => t.Category).HasColumnName("Category");
        }
    }
}
