using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CommTrckMap : EntityTypeConfiguration<CommTrck>
    {
        public CommTrckMap()
        {
            // Primary Key
            this.HasKey(t => t.CommTrackId);

            // Properties
            this.Property(t => t.venue)
                .HasMaxLength(50);

            this.Property(t => t.duration)
                .HasMaxLength(50);

            this.Property(t => t.objective)
                .HasMaxLength(500);

            this.Property(t => t.minofcomm)
                .HasMaxLength(500);

            this.Property(t => t.Comments)
                .HasMaxLength(500);

            this.Property(t => t.PitchingStage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommTrck");
            this.Property(t => t.CommTrackId).HasColumnName("CommTrackId");
            this.Property(t => t.CommId).HasColumnName("CommId");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.MeetingDate).HasColumnName("MeetingDate");
            this.Property(t => t.venue).HasColumnName("venue");
            this.Property(t => t.interacted).HasColumnName("interacted");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.objective).HasColumnName("objective");
            this.Property(t => t.minofcomm).HasColumnName("minofcomm");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.PitchingStage).HasColumnName("PitchingStage");
        }
    }
}
