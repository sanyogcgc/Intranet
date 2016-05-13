using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SkillMap : EntityTypeConfiguration<Skill>
    {
        public SkillMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillId);

            // Properties
            this.Property(t => t.SkillName)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("Skills");
            this.Property(t => t.SkillId).HasColumnName("SkillId");
            this.Property(t => t.SkillSubCatId).HasColumnName("SkillSubCatId");
            this.Property(t => t.SkillName).HasColumnName("SkillName");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
