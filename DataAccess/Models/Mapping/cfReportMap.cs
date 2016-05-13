using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class cfReportMap : EntityTypeConfiguration<cfReport>
    {
        public cfReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Training, t.Venue });

            // Properties
            this.Property(t => t.Training)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Trainer)
                .HasMaxLength(100);

            this.Property(t => t.Date)
                .HasMaxLength(10);

            this.Property(t => t.Time)
                .HasMaxLength(50);

            this.Property(t => t.Venue)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("cfReport");
            this.Property(t => t.Training).HasColumnName("Training");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Venue).HasColumnName("Venue");
            this.Property(t => t.TEAOS1).HasColumnName("TEAOS1");
            this.Property(t => t.TEAOS2).HasColumnName("TEAOS2");
            this.Property(t => t.TEAOS3).HasColumnName("TEAOS3");
            this.Property(t => t.TEAOS4).HasColumnName("TEAOS4");
            this.Property(t => t.TEAOS5).HasColumnName("TEAOS5");
            this.Property(t => t.FOT1).HasColumnName("FOT1");
            this.Property(t => t.FOT2).HasColumnName("FOT2");
            this.Property(t => t.FOT3).HasColumnName("FOT3");
            this.Property(t => t.FOT4).HasColumnName("FOT4");
            this.Property(t => t.FOT5).HasColumnName("FOT5");
            this.Property(t => t.GFbk1).HasColumnName("GFbk1");
            this.Property(t => t.GFbk2).HasColumnName("GFbk2");
            this.Property(t => t.GFbk3).HasColumnName("GFbk3");
            this.Property(t => t.GFbk4).HasColumnName("GFbk4");
        }
    }
}
