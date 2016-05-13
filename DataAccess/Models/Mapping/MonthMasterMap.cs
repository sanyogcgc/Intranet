using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MonthMasterMap : EntityTypeConfiguration<MonthMaster>
    {
        public MonthMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.MonthId);

            // Properties
            this.Property(t => t.MonthId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MonthName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MonthMaster");
            this.Property(t => t.MonthId).HasColumnName("MonthId");
            this.Property(t => t.MonthName).HasColumnName("MonthName");
        }
    }
}
