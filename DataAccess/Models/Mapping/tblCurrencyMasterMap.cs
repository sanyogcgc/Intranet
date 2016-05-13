using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblCurrencyMasterMap : EntityTypeConfiguration<tblCurrencyMaster>
    {
        public tblCurrencyMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.CurrencyId);

            // Properties
            this.Property(t => t.CurrencyName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblCurrencyMaster");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.CurrencyName).HasColumnName("CurrencyName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
