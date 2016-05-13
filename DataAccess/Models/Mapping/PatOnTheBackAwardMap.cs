using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PatOnTheBackAwardMap : EntityTypeConfiguration<PatOnTheBackAward>
    {
        public PatOnTheBackAwardMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Uid, t.Emp_id, t.Unit, t.supervisor, t.ClientAppreciation, t.RMfeedback, t.Awards, t.Quarter, t.CreateDate });

            // Properties
            this.Property(t => t.Uid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Emp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Unit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.supervisor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RMfeedback)
                .IsRequired()
                .HasMaxLength(350);

            this.Property(t => t.Awards)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Quarter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PatOnTheBackAward");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.ClientAppreciation).HasColumnName("ClientAppreciation");
            this.Property(t => t.RMfeedback).HasColumnName("RMfeedback");
            this.Property(t => t.Awards).HasColumnName("Awards");
            this.Property(t => t.Quarter).HasColumnName("Quarter");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
