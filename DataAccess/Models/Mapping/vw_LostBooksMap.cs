using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_LostBooksMap : EntityTypeConfiguration<vw_LostBooks>
    {
        public vw_LostBooksMap()
        {
            // Primary Key
            this.HasKey(t => t.BookID);

            // Properties
            this.Property(t => t.BookID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vw_LostBooks");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.Emp_ID).HasColumnName("Emp_ID");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.DateOfLost).HasColumnName("DateOfLost");
        }
    }
}
