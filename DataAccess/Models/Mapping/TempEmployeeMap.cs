using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TempEmployeeMap : EntityTypeConfiguration<TempEmployee>
    {
        public TempEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.emp_id);

            // Properties
            this.Property(t => t.lname)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TempEmployee");
            this.Property(t => t.lname).HasColumnName("lname");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.unit).HasColumnName("unit");
        }
    }
}
