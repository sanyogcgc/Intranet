using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SalaryMap : EntityTypeConfiguration<Salary>
    {
        public SalaryMap()
        {
            // Primary Key
            this.HasKey(t => t.Sal_Id);

            // Properties
            this.Property(t => t.pmtDetails)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Salary");
            this.Property(t => t.Sal_Id).HasColumnName("Sal_Id");
            this.Property(t => t.Salary1).HasColumnName("Salary");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.Emp_Id).HasColumnName("Emp_Id");
            this.Property(t => t.pmtType_Id).HasColumnName("pmtType_Id");
            this.Property(t => t.pmtDetails).HasColumnName("pmtDetails");
        }
    }
}
