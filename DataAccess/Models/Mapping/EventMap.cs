using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.Event_Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(150);

            this.Property(t => t.Category)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Event");
            this.Property(t => t.Event_Id).HasColumnName("Event_Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.Category).HasColumnName("Category");
        }
    }
}
