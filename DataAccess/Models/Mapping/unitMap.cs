using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class unitMap : EntityTypeConfiguration<unit>
    {
        public unitMap()
        {
            // Primary Key
            this.HasKey(t => t.Unit_id);

            // Properties
            this.Property(t => t.Unit_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Unit_name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("unit");
            this.Property(t => t.Unit_id).HasColumnName("Unit_id");
            this.Property(t => t.Unit_name).HasColumnName("Unit_name");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.UnitHeadEmpId).HasColumnName("UnitHeadEmpId");
        }
    }
}
