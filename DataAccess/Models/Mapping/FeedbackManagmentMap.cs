using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class FeedbackManagmentMap : EntityTypeConfiguration<FeedbackManagment>
    {
        public FeedbackManagmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Uid);

            // Properties
            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.RmComment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("FeedbackManagment");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.LoginEmp_id).HasColumnName("LoginEmp_id");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.EmpCode).HasColumnName("EmpCode");
            this.Property(t => t.Supervisor).HasColumnName("Supervisor");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Feedback).HasColumnName("Feedback");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.RmComment).HasColumnName("RmComment");
            this.Property(t => t.IsApprove).HasColumnName("IsApprove");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
