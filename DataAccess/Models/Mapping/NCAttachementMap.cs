using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCAttachementMap : EntityTypeConfiguration<NCAttachement>
    {
        public NCAttachementMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NC_Number, t.AttachedDocumentName });

            // Properties
            this.Property(t => t.NC_Number)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.AttachedDocumentName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NCAttachements");
            this.Property(t => t.NC_Number).HasColumnName("NC_Number");
            this.Property(t => t.AttachedDocumentName).HasColumnName("AttachedDocumentName");
        }
    }
}
