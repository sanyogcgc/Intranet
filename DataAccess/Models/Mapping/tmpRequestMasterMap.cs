using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tmpRequestMasterMap : EntityTypeConfiguration<tmpRequestMaster>
    {
        public tmpRequestMasterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Reqid, t.fromDate, t.toDate, t.unitID, t.status });

            // Properties
            this.Property(t => t.Reqid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Report)
                .HasMaxLength(50);

            this.Property(t => t.unitID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tmpRequestMaster");
            this.Property(t => t.Reqid).HasColumnName("Reqid");
            this.Property(t => t.Report).HasColumnName("Report");
            this.Property(t => t.fromDate).HasColumnName("fromDate");
            this.Property(t => t.toDate).HasColumnName("toDate");
            this.Property(t => t.unitID).HasColumnName("unitID");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
