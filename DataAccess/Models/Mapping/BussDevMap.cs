using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class BussDevMap : EntityTypeConfiguration<BussDev>
    {
        public BussDevMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Business_Developer)
                .HasMaxLength(50);

            this.Property(t => t.Login_ID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BussDev");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Business_Developer).HasColumnName("Business_Developer");
            this.Property(t => t.Login_ID).HasColumnName("Login_ID");
        }
    }
}
