using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblGeographyMasterMap : EntityTypeConfiguration<tblGeographyMaster>
    {
        public tblGeographyMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographyId);

            // Properties
            this.Property(t => t.GeographyName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblGeographyMaster");
            this.Property(t => t.GeographyId).HasColumnName("GeographyId");
            this.Property(t => t.GeographyName).HasColumnName("GeographyName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
