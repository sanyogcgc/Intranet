using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class sampTarUserMap : EntityTypeConfiguration<sampTarUser>
    {
        public sampTarUserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tar_id, t.user_id });

            // Properties
            this.Property(t => t.tar_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.user_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.emailid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sampTarUser");
            this.Property(t => t.tar_id).HasColumnName("tar_id");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.emailid).HasColumnName("emailid");
        }
    }
}
