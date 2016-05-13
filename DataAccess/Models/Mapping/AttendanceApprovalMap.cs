using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class AttendanceApprovalMap : EntityTypeConfiguration<AttendanceApproval>
    {
        public AttendanceApprovalMap()
        {
            // Primary Key
            this.HasKey(t => t.ApprovalID);

            // Properties
            this.Property(t => t.ReasonForNoPunch)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.TLComments)
                .HasMaxLength(500);

            this.Property(t => t.HRGComments)
                .HasMaxLength(500);

            this.Property(t => t.PunchMode)
                .HasMaxLength(50);

            this.Property(t => t.PunchTime)
                .HasMaxLength(50);

            this.Property(t => t.PunchInTime)
                .HasMaxLength(50);

            this.Property(t => t.PunchOutTime)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AttendanceApproval");
            this.Property(t => t.ApprovalID).HasColumnName("ApprovalID");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
            this.Property(t => t.ForDate).HasColumnName("ForDate");
            this.Property(t => t.ReasonForNoPunch).HasColumnName("ReasonForNoPunch");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.TLStatus).HasColumnName("TLStatus");
            this.Property(t => t.TLComments).HasColumnName("TLComments");
            this.Property(t => t.TLResponseDate).HasColumnName("TLResponseDate");
            this.Property(t => t.HRGStatus).HasColumnName("HRGStatus");
            this.Property(t => t.HRGComments).HasColumnName("HRGComments");
            this.Property(t => t.HRGResponseDate).HasColumnName("HRGResponseDate");
            this.Property(t => t.PunchMode).HasColumnName("PunchMode");
            this.Property(t => t.PunchTime).HasColumnName("PunchTime");
            this.Property(t => t.PunchInTime).HasColumnName("PunchInTime");
            this.Property(t => t.PunchOutTime).HasColumnName("PunchOutTime");
        }
    }
}
