using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class taruserMap : EntityTypeConfiguration<taruser>
    {
        public taruserMap()
        {
            // Primary Key
            this.HasKey(t => t.user_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tarusers");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.security_level).HasColumnName("security_level");
            this.Property(t => t.notify_new).HasColumnName("notify_new");
            this.Property(t => t.notify_original).HasColumnName("notify_original");
            this.Property(t => t.notify_reassignment).HasColumnName("notify_reassignment");
            this.Property(t => t.allow_upload).HasColumnName("allow_upload");
            this.Property(t => t.defaultprofile).HasColumnName("defaultprofile");
            this.Property(t => t.closedtardays).HasColumnName("closedtardays");
        }
    }
}
