using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class sampEmpMap : EntityTypeConfiguration<sampEmp>
    {
        public sampEmpMap()
        {
            // Primary Key
            this.HasKey(t => t.emp_id);

            // Properties
            this.Property(t => t.fname)
                .HasMaxLength(50);

            this.Property(t => t.lname)
                .HasMaxLength(50);

            this.Property(t => t.emailid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sampEmp");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.fname).HasColumnName("fname");
            this.Property(t => t.lname).HasColumnName("lname");
            this.Property(t => t.emailid).HasColumnName("emailid");
        }
    }
}
