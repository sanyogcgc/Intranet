using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vCommTrckDetMap : EntityTypeConfiguration<vCommTrckDet>
    {
        public vCommTrckDetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Unit_id, t.ID });

            // Properties
            this.Property(t => t.Fname)
                .HasMaxLength(50);

            this.Property(t => t.Lname)
                .HasMaxLength(50);

            this.Property(t => t.duration)
                .HasMaxLength(50);

            this.Property(t => t.venue)
                .HasMaxLength(50);

            this.Property(t => t.objective)
                .HasMaxLength(500);

            this.Property(t => t.minofcomm)
                .HasMaxLength(500);

            this.Property(t => t.Comments)
                .HasMaxLength(500);

            this.Property(t => t.PitchingStage)
                .HasMaxLength(50);

            this.Property(t => t.Unit_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vCommTrckDet");
            this.Property(t => t.MeetingDate).HasColumnName("MeetingDate");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Lname).HasColumnName("Lname");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.venue).HasColumnName("venue");
            this.Property(t => t.objective).HasColumnName("objective");
            this.Property(t => t.minofcomm).HasColumnName("minofcomm");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.PitchingStage).HasColumnName("PitchingStage");
            this.Property(t => t.Unit_id).HasColumnName("Unit_id");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
