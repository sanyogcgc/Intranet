using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PeriodMasterMap : EntityTypeConfiguration<PeriodMaster>
    {
        public PeriodMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.PeriodId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Period)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("PeriodMaster");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.Period).HasColumnName("Period");
        }
    }
}
