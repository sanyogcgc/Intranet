using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            // Primary Key
            this.HasKey(t => t.status_id);

            // Properties
            this.Property(t => t.status1)
                .HasMaxLength(20);

            this.Property(t => t.description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Statuses");
            this.Property(t => t.status_id).HasColumnName("status_id");
            this.Property(t => t.status1).HasColumnName("status");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.stat_order).HasColumnName("stat_order");
            this.Property(t => t.Intern).HasColumnName("Intern");
            this.Property(t => t.Extern).HasColumnName("Extern");
        }
    }
}
