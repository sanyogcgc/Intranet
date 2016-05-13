using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class timelogMap : EntityTypeConfiguration<timelog>
    {
        public timelogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Sno, t.ename });

            // Properties
            this.Property(t => t.Sno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ename)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.arrival)
                .HasMaxLength(50);

            this.Property(t => t.finish)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("timelog");
            this.Property(t => t.Sno).HasColumnName("Sno");
            this.Property(t => t.ename).HasColumnName("ename");
            this.Property(t => t.sysdate).HasColumnName("sysdate");
            this.Property(t => t.arrival).HasColumnName("arrival");
            this.Property(t => t.finish).HasColumnName("finish");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
