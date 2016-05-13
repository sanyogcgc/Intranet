using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Status_For_RDBMap : EntityTypeConfiguration<Status_For_RDB>
    {
        public Status_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusId);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Status_For_RDB");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
        }
    }
}
