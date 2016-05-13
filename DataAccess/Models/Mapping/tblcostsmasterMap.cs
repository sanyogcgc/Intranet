using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblcostsmasterMap : EntityTypeConfiguration<tblcostsmaster>
    {
        public tblcostsmasterMap()
        {
            // Primary Key
            this.HasKey(t => t.CostId);

            // Properties
            this.Property(t => t.Cost)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblcostsmaster");
            this.Property(t => t.CostId).HasColumnName("CostId");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
