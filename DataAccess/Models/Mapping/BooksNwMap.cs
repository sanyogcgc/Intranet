using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class BooksNwMap : EntityTypeConfiguration<BooksNw>
    {
        public BooksNwMap()
        {
            // Primary Key
            this.HasKey(t => t.BookID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(200);

            this.Property(t => t.Author)
                .HasMaxLength(200);

            this.Property(t => t.Publisher)
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            this.Property(t => t.IsAvailable)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BookCode)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.Subject)
                .HasMaxLength(200);

            this.Property(t => t.Cost)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BooksNw");
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
            this.Property(t => t.Cost).HasColumnName("Cost");
        }
    }
}
