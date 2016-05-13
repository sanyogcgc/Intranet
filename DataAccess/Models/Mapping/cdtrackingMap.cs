using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class cdtrackingMap : EntityTypeConfiguration<cdtracking>
    {
        public cdtrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.sno);

            // Properties
            this.Property(t => t.title)
                .HasMaxLength(50);

            this.Property(t => t.vouchid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("cdtracking");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.tdate).HasColumnName("tdate");
            this.Property(t => t.uid).HasColumnName("uid");
            this.Property(t => t.rdate).HasColumnName("rdate");
            this.Property(t => t.vouchid).HasColumnName("vouchid");
        }
    }
}
