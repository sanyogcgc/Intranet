using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PriorityMap : EntityTypeConfiguration<Priority>
    {
        public PriorityMap()
        {
            // Primary Key
            this.HasKey(t => t.priority_id);

            // Properties
            this.Property(t => t.priority_code)
                .HasMaxLength(15);

            this.Property(t => t.priority_desc)
                .HasMaxLength(50);

            this.Property(t => t.priority_color)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Priorities");
            this.Property(t => t.priority_id).HasColumnName("priority_id");
            this.Property(t => t.priority_code).HasColumnName("priority_code");
            this.Property(t => t.priority_desc).HasColumnName("priority_desc");
            this.Property(t => t.priority_order).HasColumnName("priority_order");
            this.Property(t => t.priority_color).HasColumnName("priority_color");
        }
    }
}
