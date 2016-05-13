using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VendorMap : EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Vendor1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vendor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Vendor1).HasColumnName("Vendor");
        }
    }
}
