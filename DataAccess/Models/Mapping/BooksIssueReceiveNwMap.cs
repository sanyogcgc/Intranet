using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class BooksIssueReceiveNwMap : EntityTypeConfiguration<BooksIssueReceiveNw>
    {
        public BooksIssueReceiveNwMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BookID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BookID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Purpose)
                .HasMaxLength(20);

            this.Property(t => t.BookCondition)
                .HasMaxLength(50);

            this.Property(t => t.IsLost)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("BooksIssueReceiveNw");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.Emp_ID).HasColumnName("Emp_ID");
            this.Property(t => t.Purpose).HasColumnName("Purpose");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.ReturnDate).HasColumnName("ReturnDate");
            this.Property(t => t.BookCondition).HasColumnName("BookCondition");
            this.Property(t => t.IsLost).HasColumnName("IsLost");
            this.Property(t => t.DateOfLost).HasColumnName("DateOfLost");
        }
    }
}
