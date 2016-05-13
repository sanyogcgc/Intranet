using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblServicesMasterMap : EntityTypeConfiguration<tblServicesMaster>
    {
        public tblServicesMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceId);

            // Properties
            this.Property(t => t.ServiceName)
                .HasMaxLength(50);

            this.Property(t => t.ServiceAbb)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblServicesMaster");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
            this.Property(t => t.ServiceAbb).HasColumnName("ServiceAbb");
        }
    }
}
