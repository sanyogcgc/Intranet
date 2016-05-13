using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaveGrantMap : EntityTypeConfiguration<LeaveGrant>
    {
        public LeaveGrantMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.TimeTypeFrom)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TimeTypeTo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NoOfDays)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.Cause)
                .HasMaxLength(8000);

            this.Property(t => t.isCompoff)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LeaveGrant");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.EntryDate).HasColumnName("EntryDate");
            this.Property(t => t.LeaveCategoryId).HasColumnName("LeaveCategoryId");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.TimeTypeFrom).HasColumnName("TimeTypeFrom");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.TimeTypeTo).HasColumnName("TimeTypeTo");
            this.Property(t => t.NoOfDays).HasColumnName("NoOfDays");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.UpdateOn).HasColumnName("UpdateOn");
            this.Property(t => t.Cause).HasColumnName("Cause");
            this.Property(t => t.isCompoff).HasColumnName("isCompoff");
        }
    }
}
