using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblAPMasterMap : EntityTypeConfiguration<tblAPMaster>
    {
        public tblAPMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.APId);

            // Properties
            this.Property(t => t.APName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblAPMaster");
            this.Property(t => t.APId).HasColumnName("APId");
            this.Property(t => t.APName).HasColumnName("APName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
