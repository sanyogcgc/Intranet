using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblCurrencyExchangeMap : EntityTypeConfiguration<tblCurrencyExchange>
    {
        public tblCurrencyExchangeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SerialNo, t.CurrencyId });

            // Properties
            this.Property(t => t.SerialNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CurrencyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.months)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblCurrencyExchange");
            this.Property(t => t.SerialNo).HasColumnName("SerialNo");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.INRExchangeAmout).HasColumnName("INRExchangeAmout");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
            this.Property(t => t.years).HasColumnName("years");
            this.Property(t => t.months).HasColumnName("months");
        }
    }
}
