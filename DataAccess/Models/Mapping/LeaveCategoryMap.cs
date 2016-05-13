using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeaveCategoryMap : EntityTypeConfiguration<LeaveCategory>
    {
        public LeaveCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.LeaveCategoryId);

            // Properties
            this.Property(t => t.Leavecategory1)
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .HasMaxLength(8000);

            this.Property(t => t.IsCarryForward)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FinYesrID)
                .HasMaxLength(50);

            this.Property(t => t.AfterOneYear)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Acts)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("LeaveCategory");
            this.Property(t => t.LeaveCategoryId).HasColumnName("LeaveCategoryId");
            this.Property(t => t.Leavecategory1).HasColumnName("Leavecategory");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.LeaveDays3).HasColumnName("LeaveDays3");
            this.Property(t => t.IsCarryForward).HasColumnName("IsCarryForward");
            this.Property(t => t.FinYesrID).HasColumnName("FinYesrID");
            this.Property(t => t.LeaveDays6).HasColumnName("LeaveDays6");
            this.Property(t => t.AfterOneYear).HasColumnName("AfterOneYear");
            this.Property(t => t.Acts).HasColumnName("Acts");
        }
    }
}
