using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VwAllMissedBookMap : EntityTypeConfiguration<VwAllMissedBook>
    {
        public VwAllMissedBookMap()
        {
            // Primary Key
            this.HasKey(t => t.BookID);

            // Properties
            this.Property(t => t.BookID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsLost)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("VwAllMissedBook");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.IsLost).HasColumnName("IsLost");
            this.Property(t => t.DateOfLost).HasColumnName("DateOfLost");
            this.Property(t => t.Emp_ID).HasColumnName("Emp_ID");
        }
    }
}
