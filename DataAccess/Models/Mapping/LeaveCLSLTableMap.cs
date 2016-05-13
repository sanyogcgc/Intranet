using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaveCLSLTableMap : EntityTypeConfiguration<LeaveCLSLTable>
    {
        public LeaveCLSLTableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Sno, t.Month });

            // Properties
            this.Property(t => t.Sno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Month)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LeaveCLSLTable");
            this.Property(t => t.Sno).HasColumnName("Sno");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.NoCL).HasColumnName("NoCL");
            this.Property(t => t.NoSL).HasColumnName("NoSL");
        }
    }
}
