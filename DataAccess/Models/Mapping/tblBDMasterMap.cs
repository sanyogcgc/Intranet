using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblBDMasterMap : EntityTypeConfiguration<tblBDMaster>
    {
        public tblBDMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.BDId);

            // Properties
            this.Property(t => t.BDId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BDName)
                .HasMaxLength(100);

            this.Property(t => t.BDM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblBDMaster");
            this.Property(t => t.BDId).HasColumnName("BDId");
            this.Property(t => t.BDName).HasColumnName("BDName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
            this.Property(t => t.serviceid).HasColumnName("serviceid");
            this.Property(t => t.BDM).HasColumnName("BDM");
        }
    }
}
