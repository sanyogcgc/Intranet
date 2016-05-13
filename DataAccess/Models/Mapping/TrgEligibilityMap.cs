using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgEligibilityMap : EntityTypeConfiguration<TrgEligibility>
    {
        public TrgEligibilityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Designation_id, t.TrgID });

            // Properties
            this.Property(t => t.Designation_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TrgID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TrgEligibility");
            this.Property(t => t.Designation_id).HasColumnName("Designation_id");
            this.Property(t => t.TrgID).HasColumnName("TrgID");
        }
    }
}
