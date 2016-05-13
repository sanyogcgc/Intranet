using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PaymentReceiptMap : EntityTypeConfiguration<PaymentReceipt>
    {
        public PaymentReceiptMap()
        {
            // Primary Key
            this.HasKey(t => t.ReceiptID);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("PaymentReceipt");
            this.Property(t => t.ReceiptID).HasColumnName("ReceiptID");
            this.Property(t => t.MilID).HasColumnName("MilID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DateReceipt).HasColumnName("DateReceipt");
            this.Property(t => t.TDS).HasColumnName("TDS");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.PaymentType).HasColumnName("PaymentType");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
        }
    }
}
