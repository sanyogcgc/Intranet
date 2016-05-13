using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblMonthMasterMap : EntityTypeConfiguration<tblMonthMaster>
    {
        public tblMonthMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.monthID);

            // Properties
            this.Property(t => t.monthID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.monthName)
                .HasMaxLength(50);

            this.Property(t => t.monthAbbrv)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblMonthMaster");
            this.Property(t => t.monthID).HasColumnName("monthID");
            this.Property(t => t.monthName).HasColumnName("monthName");
            this.Property(t => t.monthAbbrv).HasColumnName("monthAbbrv");
        }
    }
}
