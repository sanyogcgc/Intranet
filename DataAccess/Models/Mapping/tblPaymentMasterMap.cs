using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblPaymentMasterMap : EntityTypeConfiguration<tblPaymentMaster>
    {
        public tblPaymentMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentId);

            // Properties
            this.Property(t => t.PaymentType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblPaymentMaster");
            this.Property(t => t.PaymentId).HasColumnName("PaymentId");
            this.Property(t => t.PaymentType).HasColumnName("PaymentType");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
