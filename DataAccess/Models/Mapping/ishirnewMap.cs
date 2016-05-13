using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ishirnewMap : EntityTypeConfiguration<ishirnew>
    {
        public ishirnewMap()
        {
            // Primary Key
            this.HasKey(t => t.sno);

            // Properties
            this.Property(t => t.news)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("ishirnews");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.news).HasColumnName("news");
        }
    }
}
