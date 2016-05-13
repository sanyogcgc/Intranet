using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Exp_Sub_CategoryMap : EntityTypeConfiguration<Exp_Sub_Category>
    {
        public Exp_Sub_CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Sub_Category)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Exp_Sub_Category");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Category_Code).HasColumnName("Category_Code");
            this.Property(t => t.Sub_Category).HasColumnName("Sub_Category");
        }
    }
}
