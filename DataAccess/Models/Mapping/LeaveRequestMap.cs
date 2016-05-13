using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaveRequestMap : EntityTypeConfiguration<LeaveRequest>
    {
        public LeaveRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.RequestDate)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.IsCompOff)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TimeTypeFrom)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TimeTypeTo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OtherCause)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RequestTo)
                .HasMaxLength(250);

            this.Property(t => t.RequestCc)
                .HasMaxLength(250);

            this.Property(t => t.UpdatedOn)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("LeaveRequest");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.IsCompOff).HasColumnName("IsCompOff");
            this.Property(t => t.LeaveCategoryId).HasColumnName("LeaveCategoryId");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.TimeTypeFrom).HasColumnName("TimeTypeFrom");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.TimeTypeTo).HasColumnName("TimeTypeTo");
            this.Property(t => t.CauseID).HasColumnName("CauseID");
            this.Property(t => t.OtherCause).HasColumnName("OtherCause");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.SupervisorID).HasColumnName("SupervisorID");
            this.Property(t => t.Comp_fordate).HasColumnName("Comp_fordate");
            this.Property(t => t.RequestTo).HasColumnName("RequestTo");
            this.Property(t => t.RequestCc).HasColumnName("RequestCc");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
            this.Property(t => t.Leave_Auth_Id).HasColumnName("Leave_Auth_Id");
        }
    }
}
