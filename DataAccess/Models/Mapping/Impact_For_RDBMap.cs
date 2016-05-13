using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Impact_For_RDBMap : EntityTypeConfiguration<Impact_For_RDB>
    {
        public Impact_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => t.Impact);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Impact_For_RDB");
            this.Property(t => t.Impact).HasColumnName("Impact");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
