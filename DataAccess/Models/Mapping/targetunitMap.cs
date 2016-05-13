using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class targetunitMap : EntityTypeConfiguration<targetunit>
    {
        public targetunitMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("targetunit");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.unitid).HasColumnName("unitid");
            this.Property(t => t.teamcost).HasColumnName("teamcost");
            this.Property(t => t.targetmonth).HasColumnName("targetmonth");
            this.Property(t => t.targetyear).HasColumnName("targetyear");
        }
    }
}
