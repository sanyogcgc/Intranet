using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblProjectMilestoneDetails1Map : EntityTypeConfiguration<tblProjectMilestoneDetails1>
    {
        public tblProjectMilestoneDetails1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.MilestoneId, t.PIN });

            // Properties
            this.Property(t => t.MilestoneId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PIN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MilestoneDescription)
                .HasMaxLength(50);

            this.Property(t => t.DateReceived)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(50);

            this.Property(t => t.months)
                .HasMaxLength(50);

            this.Property(t => t.status)
                .HasMaxLength(50);

            this.Property(t => t.payment)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblProjectMilestoneDetails1");
            this.Property(t => t.MilestoneId).HasColumnName("MilestoneId");
            this.Property(t => t.PIN).HasColumnName("PIN");
            this.Property(t => t.MilestoneDescription).HasColumnName("MilestoneDescription");
            this.Property(t => t.DatePlanned).HasColumnName("DatePlanned");
            this.Property(t => t.DateReceived).HasColumnName("DateReceived");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
            this.Property(t => t.months).HasColumnName("months");
            this.Property(t => t.years).HasColumnName("years");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.payment).HasColumnName("payment");
            this.Property(t => t.years1).HasColumnName("years1");
        }
    }
}
