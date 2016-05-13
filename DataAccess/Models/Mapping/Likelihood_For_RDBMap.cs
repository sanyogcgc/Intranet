using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Likelihood_For_RDBMap : EntityTypeConfiguration<Likelihood_For_RDB>
    {
        public Likelihood_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => t.Likelihood);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Likelihood_For_RDB");
            this.Property(t => t.Likelihood).HasColumnName("Likelihood");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
