using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class temptimelogMap : EntityTypeConfiguration<temptimelog>
    {
        public temptimelogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sno, t.ename });

            // Properties
            this.Property(t => t.sno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ename)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tempout)
                .HasMaxLength(50);

            this.Property(t => t.tempin)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("temptimelog");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.ename).HasColumnName("ename");
            this.Property(t => t.sysdate).HasColumnName("sysdate");
            this.Property(t => t.tempout).HasColumnName("tempout");
            this.Property(t => t.tempin).HasColumnName("tempin");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
