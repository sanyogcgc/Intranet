using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class HolidayMap : EntityTypeConfiguration<Holiday>
    {
        public HolidayMap()
        {
            // Primary Key
            this.HasKey(t => t.Holiday_Id);

            // Properties
            this.Property(t => t.Holiday_Name)
                .HasMaxLength(255);

            this.Property(t => t.Restricted_Holiday)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Holiday");
            this.Property(t => t.Holiday_Id).HasColumnName("Holiday_Id");
            this.Property(t => t.Holiday_Date).HasColumnName("Holiday_Date");
            this.Property(t => t.Holiday_Name).HasColumnName("Holiday_Name");
            this.Property(t => t.Restricted_Holiday).HasColumnName("Restricted_Holiday");
        }
    }
}
