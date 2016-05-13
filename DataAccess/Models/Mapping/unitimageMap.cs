using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class unitimageMap : EntityTypeConfiguration<unitimage>
    {
        public unitimageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Unitname)
                .HasMaxLength(50);

            this.Property(t => t.unitImage1)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("unitimages");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Unitname).HasColumnName("Unitname");
            this.Property(t => t.unitImage1).HasColumnName("unitImage");
        }
    }
}
