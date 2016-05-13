using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class timespentlogMap : EntityTypeConfiguration<timespentlog>
    {
        public timespentlogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sno, t.ename });

            // Properties
            this.Property(t => t.sno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ename)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.timespent)
                .HasMaxLength(50);

            this.Property(t => t.partner)
                .HasMaxLength(50);

            this.Property(t => t.back_up)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.cleanliness)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("timespentlog");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.ename).HasColumnName("ename");
            this.Property(t => t.sysdate).HasColumnName("sysdate");
            this.Property(t => t.timespent).HasColumnName("timespent");
            this.Property(t => t.partner).HasColumnName("partner");
            this.Property(t => t.back_up).HasColumnName("back_up");
            this.Property(t => t.cleanliness).HasColumnName("cleanliness");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
