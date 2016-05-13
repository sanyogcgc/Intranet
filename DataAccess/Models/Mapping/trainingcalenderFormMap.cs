using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class trainingcalenderFormMap : EntityTypeConfiguration<trainingcalenderForm>
    {
        public trainingcalenderFormMap()
        {
            // Primary Key
            this.HasKey(t => t.TC_ID);

            // Properties
            this.Property(t => t.Trainer)
                .HasMaxLength(250);

            this.Property(t => t.Time)
                .HasMaxLength(50);

            this.Property(t => t.Venue)
                .HasMaxLength(250);

            this.Property(t => t.participants)
                .HasMaxLength(700);

            this.Property(t => t.Objective)
                .HasMaxLength(500);

            this.Property(t => t.TrainingStatus)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("trainingcalenderForm");
            this.Property(t => t.TC_ID).HasColumnName("TC_ID");
            this.Property(t => t.CatagoryID).HasColumnName("CatagoryID");
            this.Property(t => t.TrainingID).HasColumnName("TrainingID");
            this.Property(t => t.Trainer).HasColumnName("Trainer");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Venue).HasColumnName("Venue");
            this.Property(t => t.Quarter).HasColumnName("Quarter");
            this.Property(t => t.participants).HasColumnName("participants");
            this.Property(t => t.Objective).HasColumnName("Objective");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.TrainingStatus).HasColumnName("TrainingStatus");
        }
    }
}
