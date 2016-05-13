using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW7Map : EntityTypeConfiguration<VIEW7>
    {
        public VIEW7Map()
        {
            // Primary Key
            this.HasKey(t => t.EmpID);

            // Properties
            this.Property(t => t.Unit_name)
                .HasMaxLength(50);

            this.Property(t => t.Designation_name)
                .HasMaxLength(50);

            this.Property(t => t.EmpID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fname)
                .HasMaxLength(50);

            this.Property(t => t.Mname)
                .HasMaxLength(50);

            this.Property(t => t.Lname)
                .HasMaxLength(50);

            this.Property(t => t.LeaveTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VIEW7");
            this.Property(t => t.Unit_name).HasColumnName("Unit_name");
            this.Property(t => t.Designation_name).HasColumnName("Designation_name");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Mname).HasColumnName("Mname");
            this.Property(t => t.Lname).HasColumnName("Lname");
            this.Property(t => t.LeaveTypeName).HasColumnName("LeaveTypeName");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.NumberOfLeavesAvailed).HasColumnName("NumberOfLeavesAvailed");
            this.Property(t => t.NumberOfLeavesAllowed).HasColumnName("NumberOfLeavesAllowed");
        }
    }
}
