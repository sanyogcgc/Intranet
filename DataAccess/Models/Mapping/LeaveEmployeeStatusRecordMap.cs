using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaveEmployeeStatusRecordMap : EntityTypeConfiguration<LeaveEmployeeStatusRecord>
    {
        public LeaveEmployeeStatusRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmpID, t.LeaveTypeID });

            // Properties
            this.Property(t => t.EmpID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LeaveTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("LeaveEmployeeStatusRecord");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
            this.Property(t => t.LeaveTypeID).HasColumnName("LeaveTypeID");
            this.Property(t => t.NumberOfLeavesAvailed).HasColumnName("NumberOfLeavesAvailed");
            this.Property(t => t.NumberOfLeavesLeft).HasColumnName("NumberOfLeavesLeft");
            this.Property(t => t.NumberOfLeavesAllowed).HasColumnName("NumberOfLeavesAllowed");
        }
    }
}
