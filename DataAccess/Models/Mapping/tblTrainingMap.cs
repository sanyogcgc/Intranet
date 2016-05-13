using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblTrainingMap : EntityTypeConfiguration<tblTraining>
    {
        public tblTrainingMap()
        {
            // Primary Key
            this.HasKey(t => t.TrainingID);

            // Properties
            this.Property(t => t.TrainingName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblTraining");
            this.Property(t => t.TrainingID).HasColumnName("TrainingID");
            this.Property(t => t.TrainingName).HasColumnName("TrainingName");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
