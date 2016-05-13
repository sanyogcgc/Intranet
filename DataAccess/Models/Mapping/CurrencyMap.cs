using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CurrencyMap : EntityTypeConfiguration<Currency>
    {
        public CurrencyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Currency_Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Currencies");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Currency_Name).HasColumnName("Currency_Name");
            this.Property(t => t.Exchange_Rate).HasColumnName("Exchange_Rate");
        }
    }
}
