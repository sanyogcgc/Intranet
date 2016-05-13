using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ReceiptUnitMap : EntityTypeConfiguration<ReceiptUnit>
    {
        public ReceiptUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.ReceiptID);

            // Properties
            this.Property(t => t.ReceiptID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ReceiptUnit");
            this.Property(t => t.ReceiptID).HasColumnName("ReceiptID");
            this.Property(t => t.MilID).HasColumnName("MilID");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.TDS).HasColumnName("TDS");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
        }
    }
}
