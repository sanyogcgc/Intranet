using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaverequesttransactionMap : EntityTypeConfiguration<Leaverequesttransaction>
    {
        public LeaverequesttransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.LeaveRequestID);

            // Properties
            this.Property(t => t.ReasonForLeave)
                .HasMaxLength(2000);

            this.Property(t => t.PriorNotice)
                .HasMaxLength(5);

            this.Property(t => t.HalfDay)
                .HasMaxLength(50);

            this.Property(t => t.TLComments)
                .HasMaxLength(2000);

            this.Property(t => t.HRGComments)
                .HasMaxLength(2000);

            this.Property(t => t.UnitHeadComments)
                .HasMaxLength(2000);

            this.Property(t => t.Leave)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.fullday)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Leaverequesttransaction");
            this.Property(t => t.LeaveRequestID).HasColumnName("LeaveRequestID");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.ReasonForLeave).HasColumnName("ReasonForLeave");
            this.Property(t => t.LeaveTypeID).HasColumnName("LeaveTypeID");
            this.Property(t => t.NoOfLeaves).HasColumnName("NoOfLeaves");
            this.Property(t => t.PriorNotice).HasColumnName("PriorNotice");
            this.Property(t => t.DaysPriorNotice).HasColumnName("DaysPriorNotice");
            this.Property(t => t.HalfDay).HasColumnName("HalfDay");
            this.Property(t => t.LeaveSubmitDate).HasColumnName("LeaveSubmitDate");
            this.Property(t => t.TLComments).HasColumnName("TLComments");
            this.Property(t => t.TLApprovalStatusID).HasColumnName("TLApprovalStatusID");
            this.Property(t => t.TLResponseDate).HasColumnName("TLResponseDate");
            this.Property(t => t.HRGComments).HasColumnName("HRGComments");
            this.Property(t => t.HRGApprovalStatusID).HasColumnName("HRGApprovalStatusID");
            this.Property(t => t.HRGResponseDate).HasColumnName("HRGResponseDate");
            this.Property(t => t.UnitHeadComments).HasColumnName("UnitHeadComments");
            this.Property(t => t.UnitHeadApprovalStatusID).HasColumnName("UnitHeadApprovalStatusID");
            this.Property(t => t.UnitHeadResponseDate).HasColumnName("UnitHeadResponseDate");
            this.Property(t => t.Leave).HasColumnName("Leave");
            this.Property(t => t.fullday).HasColumnName("fullday");
        }
    }
}
