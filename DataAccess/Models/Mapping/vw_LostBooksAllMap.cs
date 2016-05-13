using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_LostBooksAllMap : EntityTypeConfiguration<vw_LostBooksAll>
    {
        public vw_LostBooksAllMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BookID, t.category });

            // Properties
            this.Property(t => t.BookID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Author)
                .HasMaxLength(100);

            this.Property(t => t.Publisher)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            this.Property(t => t.IsAvailable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BookCode)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Subject)
                .HasMaxLength(50);

            this.Property(t => t.Fname)
                .HasMaxLength(50);

            this.Property(t => t.Lname)
                .HasMaxLength(50);

            this.Property(t => t.category)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_LostBooksAll");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.DateofPurchase).HasColumnName("DateofPurchase");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.Publisher).HasColumnName("Publisher");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsAvailable).HasColumnName("IsAvailable");
            this.Property(t => t.BookCode).HasColumnName("BookCode");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.DateOfLost).HasColumnName("DateOfLost");
            this.Property(t => t.Emp_ID).HasColumnName("Emp_ID");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Lname).HasColumnName("Lname");
            this.Property(t => t.category).HasColumnName("category");
        }
    }
}
