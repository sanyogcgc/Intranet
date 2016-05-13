using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ADEmployeeMap : EntityTypeConfiguration<ADEmployee>
    {
        public ADEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.emp_id);

            // Properties
            this.Property(t => t.EmpName)
                .HasMaxLength(101);

            // Table & Column Mappings
            this.ToTable("ADEmployee");
            this.Property(t => t.unit).HasColumnName("unit");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.EmpName).HasColumnName("EmpName");
        }
    }
}
