using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tbl_SystemDownMap : EntityTypeConfiguration<tbl_SystemDown>
    {
        public tbl_SystemDownMap()
        {
            // Primary Key
            this.HasKey(t => t.sdid);

            // Properties
            this.Property(t => t.internet)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.intranet)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.exchange)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SoftwareInstall)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Hardware)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.slowInternet)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Others)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("tbl_SystemDown");
            this.Property(t => t.sdid).HasColumnName("sdid");
            this.Property(t => t.uid).HasColumnName("uid");
            this.Property(t => t.entrydate).HasColumnName("entrydate");
            this.Property(t => t.internet).HasColumnName("internet");
            this.Property(t => t.intranet).HasColumnName("intranet");
            this.Property(t => t.exchange).HasColumnName("exchange");
            this.Property(t => t.SoftwareInstall).HasColumnName("SoftwareInstall");
            this.Property(t => t.Hardware).HasColumnName("Hardware");
            this.Property(t => t.slowInternet).HasColumnName("slowInternet");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.Hours).HasColumnName("Hours");
        }
    }
}
