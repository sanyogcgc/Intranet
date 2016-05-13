using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaveReportingGroupMap : EntityTypeConfiguration<LeaveReportingGroup>
    {
        public LeaveReportingGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.employeeId);

            // Properties
            this.Property(t => t.employeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.employeeFname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.employeeMname)
                .HasMaxLength(50);

            this.Property(t => t.employeeLname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.employeeEmailID)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("LeaveReportingGroup");
            this.Property(t => t.employeeId).HasColumnName("employeeId");
            this.Property(t => t.employeeFname).HasColumnName("employeeFname");
            this.Property(t => t.employeeMname).HasColumnName("employeeMname");
            this.Property(t => t.employeeLname).HasColumnName("employeeLname");
            this.Property(t => t.employeeEmailID).HasColumnName("employeeEmailID");
        }
    }
}
