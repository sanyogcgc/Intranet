using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MailSettingMap : EntityTypeConfiguration<MailSetting>
    {
        public MailSettingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.i_serverid, t.i_status });

            // Properties
            this.Property(t => t.i_serverid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.c_username)
                .HasMaxLength(50);

            this.Property(t => t.c_password)
                .HasMaxLength(50);

            this.Property(t => t.c_from)
                .HasMaxLength(50);

            this.Property(t => t.c_fromdisp)
                .HasMaxLength(50);

            this.Property(t => t.c_smtpserverin)
                .HasMaxLength(50);

            this.Property(t => t.c_smtpserverout)
                .HasMaxLength(50);

            this.Property(t => t.i_status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MailSetting");
            this.Property(t => t.i_serverid).HasColumnName("i_serverid");
            this.Property(t => t.i_portout).HasColumnName("i_portout");
            this.Property(t => t.i_portin).HasColumnName("i_portin");
            this.Property(t => t.c_username).HasColumnName("c_username");
            this.Property(t => t.c_password).HasColumnName("c_password");
            this.Property(t => t.c_from).HasColumnName("c_from");
            this.Property(t => t.c_fromdisp).HasColumnName("c_fromdisp");
            this.Property(t => t.c_smtpserverin).HasColumnName("c_smtpserverin");
            this.Property(t => t.c_smtpserverout).HasColumnName("c_smtpserverout");
            this.Property(t => t.i_status).HasColumnName("i_status");
        }
    }
}
