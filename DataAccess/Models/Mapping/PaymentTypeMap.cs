using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PaymentTypeMap : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Payment_Type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PaymentType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Payment_Type).HasColumnName("Payment_Type");
        }
    }
}
