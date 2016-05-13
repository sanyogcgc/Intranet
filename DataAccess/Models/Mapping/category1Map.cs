using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class category1Map : EntityTypeConfiguration<category1>
    {
        public category1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.sno, t.category });

            // Properties
            this.Property(t => t.sno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.category)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cfield)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("category");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.cfield).HasColumnName("cfield");
        }
    }
}
