using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblProjectDurationDetailMap : EntityTypeConfiguration<tblProjectDurationDetail>
    {
        public tblProjectDurationDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SerialNo, t.PIN });

            // Properties
            this.Property(t => t.SerialNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PIN)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblProjectDurationDetails");
            this.Property(t => t.SerialNo).HasColumnName("SerialNo");
            this.Property(t => t.PIN).HasColumnName("PIN");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.ManMonthAllocated).HasColumnName("ManMonthAllocated");
            this.Property(t => t.ValueAllocated).HasColumnName("ValueAllocated");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
