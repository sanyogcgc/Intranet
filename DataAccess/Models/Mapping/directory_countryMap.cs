using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class directory_countryMap : EntityTypeConfiguration<directory_country>
    {
        public directory_countryMap()
        {
            // Primary Key
            this.HasKey(t => t.sno);

            // Properties
            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.sno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("directory_country");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.sno).HasColumnName("sno");
        }
    }
}
