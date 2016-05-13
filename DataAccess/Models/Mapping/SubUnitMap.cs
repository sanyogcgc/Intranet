using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SubUnitMap : EntityTypeConfiguration<SubUnit>
    {
        public SubUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.SubUnitID);

            // Properties
            this.Property(t => t.SubUnitName)
                .HasMaxLength(200);

            this.Property(t => t.Abbv)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SubUnit");
            this.Property(t => t.SubUnitID).HasColumnName("SubUnitID");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.SubUnitName).HasColumnName("SubUnitName");
            this.Property(t => t.Abbv).HasColumnName("Abbv");
        }
    }
}
