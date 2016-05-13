using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TraineeMap : EntityTypeConfiguration<Trainee>
    {
        public TraineeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Attended_Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Trainee");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Event_Detail_Id).HasColumnName("Event_Detail_Id");
            this.Property(t => t.Employee_Id).HasColumnName("Employee_Id");
            this.Property(t => t.Attended_Status).HasColumnName("Attended_Status");
            this.Property(t => t.Comments).HasColumnName("Comments");

            // Relationships
            this.HasOptional(t => t.Event_Detail)
                .WithMany(t => t.Trainees)
                .HasForeignKey(d => d.Event_Detail_Id);

        }
    }
}
