using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class EmployeeLeaveMap : EntityTypeConfiguration<EmployeeLeave>
    {
        public EmployeeLeaveMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApplicableFrom)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmployeeLeave");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.FinYearID).HasColumnName("FinYearID");
            this.Property(t => t.LeaveCategoryid).HasColumnName("LeaveCategoryid");
            this.Property(t => t.TotalLeave).HasColumnName("TotalLeave");
            this.Property(t => t.ApplicableFrom).HasColumnName("ApplicableFrom");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.UpdateOn).HasColumnName("UpdateOn");
        }
    }
}
