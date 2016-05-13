using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class settingMap : EntityTypeConfiguration<setting>
    {
        public settingMap()
        {
            // Primary Key
            this.HasKey(t => t.settings_id);

            // Properties
            this.Property(t => t.settings_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.notify_new_from)
                .HasMaxLength(50);

            this.Property(t => t.notify_change_from)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("settings");
            this.Property(t => t.settings_id).HasColumnName("settings_id");
            this.Property(t => t.file_extensions).HasColumnName("file_extensions");
            this.Property(t => t.file_path).HasColumnName("file_path");
            this.Property(t => t.notify_new_from).HasColumnName("notify_new_from");
            this.Property(t => t.notify_new_subject).HasColumnName("notify_new_subject");
            this.Property(t => t.notify_new_body).HasColumnName("notify_new_body");
            this.Property(t => t.notify_change_from).HasColumnName("notify_change_from");
            this.Property(t => t.notify_change_subject).HasColumnName("notify_change_subject");
            this.Property(t => t.notify_change_body).HasColumnName("notify_change_body");
            this.Property(t => t.upload_enabled).HasColumnName("upload_enabled");
        }
    }
}
