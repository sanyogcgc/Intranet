using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Category_For_RDBMap : EntityTypeConfiguration<Category_For_RDB>
    {
        public Category_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => t.Cat_Id);

            // Properties
            this.Property(t => t.Cat_Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Category_For_RDB");
            this.Property(t => t.Cat_Id).HasColumnName("Cat_Id");
            this.Property(t => t.Cat_Name).HasColumnName("Cat_Name");
        }
    }
}
