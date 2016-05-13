using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class FinYearMasterMap : EntityTypeConfiguration<FinYearMaster>
    {
        public FinYearMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.FinYearID);

            // Properties
            this.Property(t => t.FinYear)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("FinYearMaster");
            this.Property(t => t.FinYearID).HasColumnName("FinYearID");
            this.Property(t => t.FinYear).HasColumnName("FinYear");
            this.Property(t => t.DateFrom).HasColumnName("DateFrom");
            this.Property(t => t.DateTo).HasColumnName("DateTo");
        }
    }
}
