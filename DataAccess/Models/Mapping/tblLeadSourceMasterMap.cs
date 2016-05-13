using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblLeadSourceMasterMap : EntityTypeConfiguration<tblLeadSourceMaster>
    {
        public tblLeadSourceMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.LeadSourceId);

            // Properties
            this.Property(t => t.LeadSourceName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblLeadSourceMaster");
            this.Property(t => t.LeadSourceId).HasColumnName("LeadSourceId");
            this.Property(t => t.LeadSourceName).HasColumnName("LeadSourceName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
