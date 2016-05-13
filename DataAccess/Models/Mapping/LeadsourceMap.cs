using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeadsourceMap : EntityTypeConfiguration<Leadsource>
    {
        public LeadsourceMap()
        {
            // Primary Key
            this.HasKey(t => t.Leadid);

            // Properties
            this.Property(t => t.Leadsource1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Leadsource");
            this.Property(t => t.Leadid).HasColumnName("Leadid");
            this.Property(t => t.Leadsource1).HasColumnName("Leadsource");
        }
    }
}
