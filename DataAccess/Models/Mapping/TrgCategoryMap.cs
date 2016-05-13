using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgCategoryMap : EntityTypeConfiguration<TrgCategory>
    {
        public TrgCategoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CategoryID, t.CategoryName, t.CategoryDesc });

            // Properties
            this.Property(t => t.CategoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CategoryDesc)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TrgCategory");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.CategoryDesc).HasColumnName("CategoryDesc");
            this.Property(t => t.SubCategory).HasColumnName("SubCategory");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
