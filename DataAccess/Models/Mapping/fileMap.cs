using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class fileMap : EntityTypeConfiguration<file>
    {
        public fileMap()
        {
            // Primary Key
            this.HasKey(t => t.file_id);

            // Properties
            this.Property(t => t.file_name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("files");
            this.Property(t => t.file_id).HasColumnName("file_id");
            this.Property(t => t.file_name).HasColumnName("file_name");
            this.Property(t => t.issue_id).HasColumnName("issue_id");
            this.Property(t => t.date_uploaded).HasColumnName("date_uploaded");
            this.Property(t => t.uploaded_by).HasColumnName("uploaded_by");
        }
    }
}
