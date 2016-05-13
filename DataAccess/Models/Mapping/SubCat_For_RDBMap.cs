using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SubCat_For_RDBMap : EntityTypeConfiguration<SubCat_For_RDB>
    {
        public SubCat_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => t.Sub_Cat_Id);

            // Properties
            this.Property(t => t.Sub_Cat_Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SubCat_For_RDB");
            this.Property(t => t.Sub_Cat_Id).HasColumnName("Sub_Cat_Id");
            this.Property(t => t.Sub_Cat_Name).HasColumnName("Sub_Cat_Name");
            this.Property(t => t.Cat_Id).HasColumnName("Cat_Id");
        }
    }
}
