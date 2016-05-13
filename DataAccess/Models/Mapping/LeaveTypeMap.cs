using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaveTypeMap : EntityTypeConfiguration<LeaveType>
    {
        public LeaveTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.LeaveTypeID);

            // Properties
            this.Property(t => t.LeaveTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LeaveTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LeaveDescription)
                .HasMaxLength(50);

            this.Property(t => t.Ltypes)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("LeaveTypes");
            this.Property(t => t.LeaveTypeID).HasColumnName("LeaveTypeID");
            this.Property(t => t.LeaveTypeName).HasColumnName("LeaveTypeName");
            this.Property(t => t.LeaveDescription).HasColumnName("LeaveDescription");
            this.Property(t => t.LeaveTypeAllotted).HasColumnName("LeaveTypeAllotted");
            this.Property(t => t.StartYearDate).HasColumnName("StartYearDate");
            this.Property(t => t.EndYearDate).HasColumnName("EndYearDate");
            this.Property(t => t.Ltypes).HasColumnName("Ltypes");
        }
    }
}
