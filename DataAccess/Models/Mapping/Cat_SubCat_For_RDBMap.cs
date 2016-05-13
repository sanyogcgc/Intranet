using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Cat_SubCat_For_RDBMap : EntityTypeConfiguration<Cat_SubCat_For_RDB>
    {
        public Cat_SubCat_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Cat_SubCat_For_RDB");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cat_Id).HasColumnName("Cat_Id");
            this.Property(t => t.Sub_Cat_Id).HasColumnName("Sub_Cat_Id");
        }
    }
}
