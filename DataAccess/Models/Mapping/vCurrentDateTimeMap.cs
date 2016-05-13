using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vCurrentDateTimeMap : EntityTypeConfiguration<vCurrentDateTime>
    {
        public vCurrentDateTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.gd);

            // Properties
            // Table & Column Mappings
            this.ToTable("vCurrentDateTime");
            this.Property(t => t.gd).HasColumnName("gd");
        }
    }
}
