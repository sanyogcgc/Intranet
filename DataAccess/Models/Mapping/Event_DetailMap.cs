using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Event_DetailMap : EntityTypeConfiguration<Event_Detail>
    {
        public Event_DetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Event_Detail_Id);

            // Properties
            this.Property(t => t.Agenda)
                .HasMaxLength(550);

            this.Property(t => t.Trainer)
                .HasMaxLength(100);

            this.Property(t => t.ETime)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.Venue)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Event_Detail");
            this.Property(t => t.Event_Detail_Id).HasColumnName("Event_Detail_Id");
            this.Property(t => t.Event_Id).HasColumnName("Event_Id");
            this.Property(t => t.Agenda).HasColumnName("Agenda");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.EDate).HasColumnName("EDate");
            this.Property(t => t.ETime).HasColumnName("ETime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Venue).HasColumnName("Venue");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
