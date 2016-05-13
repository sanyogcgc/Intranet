using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class worklogMap : EntityTypeConfiguration<worklog>
    {
        public worklogMap()
        {
            // Primary Key
            this.HasKey(t => t.sno);

            // Properties
            this.Property(t => t.status)
                .HasMaxLength(4000);

            this.Property(t => t.systime)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("worklog");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.date1).HasColumnName("date1");
            this.Property(t => t.uid).HasColumnName("uid");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.hours).HasColumnName("hours");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.systime).HasColumnName("systime");
            this.Property(t => t.module).HasColumnName("module");
            this.Property(t => t.unit_id).HasColumnName("unit_id");
            this.Property(t => t.sysdate).HasColumnName("sysdate");
        }
    }
}
