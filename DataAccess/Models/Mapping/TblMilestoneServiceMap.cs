using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TblMilestoneServiceMap : EntityTypeConfiguration<TblMilestoneService>
    {
        public TblMilestoneServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.SrNo);

            // Properties
            this.Property(t => t.PIN)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TblMilestoneService");
            this.Property(t => t.SrNo).HasColumnName("SrNo");
            this.Property(t => t.MilestoneId).HasColumnName("MilestoneId");
            this.Property(t => t.PIN).HasColumnName("PIN");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.AmtDue).HasColumnName("AmtDue");
            this.Property(t => t.AmtReceived).HasColumnName("AmtReceived");
        }
    }
}
