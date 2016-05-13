using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblClientMaster1Map : EntityTypeConfiguration<tblClientMaster1>
    {
        public tblClientMaster1Map()
        {
            // Primary Key
            this.HasKey(t => t.ClientIds);

            // Properties
            this.Property(t => t.ClientId)
                .HasMaxLength(50);

            this.Property(t => t.ClientName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblClientMaster1");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.ClientName).HasColumnName("ClientName");
            this.Property(t => t.BDId).HasColumnName("BDId");
            this.Property(t => t.GeographyId).HasColumnName("GeographyId");
            this.Property(t => t.LeadSourceId).HasColumnName("LeadSourceId");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
            this.Property(t => t.BusinessCategoryId).HasColumnName("BusinessCategoryId");
            this.Property(t => t.PaymentId).HasColumnName("PaymentId");
            this.Property(t => t.AccountPriorityId).HasColumnName("AccountPriorityId");
            this.Property(t => t.ClientIds).HasColumnName("ClientIds");
        }
    }
}
