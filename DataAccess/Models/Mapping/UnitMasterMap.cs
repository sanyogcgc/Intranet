using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class UnitMasterMap : EntityTypeConfiguration<UnitMaster>
    {
        public UnitMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitID);

            // Properties
            this.Property(t => t.UnitName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UnitMaster");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
