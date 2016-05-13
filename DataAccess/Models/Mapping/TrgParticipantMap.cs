using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgParticipantMap : EntityTypeConfiguration<TrgParticipant>
    {
        public TrgParticipantMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TrgSchID, t.Emp_ID });

            // Properties
            this.Property(t => t.TrgSchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.participants)
                .HasMaxLength(100);

            this.Property(t => t.Invited)
                .HasMaxLength(50);

            this.Property(t => t.Emp_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TrgParticipants");
            this.Property(t => t.TrgSchID).HasColumnName("TrgSchID");
            this.Property(t => t.participants).HasColumnName("participants");
            this.Property(t => t.Invited).HasColumnName("Invited");
            this.Property(t => t.Emp_ID).HasColumnName("Emp_ID");
            this.Property(t => t.DateFrom).HasColumnName("DateFrom");
            this.Property(t => t.Accepted).HasColumnName("Accepted");
            this.Property(t => t.Attended).HasColumnName("Attended");
            this.Property(t => t.FeedBack).HasColumnName("FeedBack");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
