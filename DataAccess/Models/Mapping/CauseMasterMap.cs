using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CauseMasterMap : EntityTypeConfiguration<CauseMaster>
    {
        public CauseMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.CauseID);

            // Properties
            this.Property(t => t.CauseName)
                .HasMaxLength(50);

            this.Property(t => t.ApplicableInAttendance)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ApplicableInLeave)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CauseMaster");
            this.Property(t => t.CauseID).HasColumnName("CauseID");
            this.Property(t => t.CauseName).HasColumnName("CauseName");
            this.Property(t => t.ApplicableInAttendance).HasColumnName("ApplicableInAttendance");
            this.Property(t => t.ApplicableInLeave).HasColumnName("ApplicableInLeave");
        }
    }
}
