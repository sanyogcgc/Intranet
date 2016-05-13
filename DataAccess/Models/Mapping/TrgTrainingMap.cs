using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgTrainingMap : EntityTypeConfiguration<TrgTraining>
    {
        public TrgTrainingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TrgID, t.TrgName });

            // Properties
            this.Property(t => t.TrgID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TrgName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TrgDescription)
                .HasMaxLength(200);

            this.Property(t => t.Purpose)
                .HasMaxLength(1000);

            this.Property(t => t.Objective)
                .HasMaxLength(1000);

            this.Property(t => t.Agenda)
                .HasMaxLength(1000);

            this.Property(t => t.Deliverable)
                .HasMaxLength(1000);

            this.Property(t => t.Pre)
                .HasMaxLength(100);

            this.Property(t => t.Success)
                .HasMaxLength(100);

            this.Property(t => t.SubCategory)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("TrgTraining");
            this.Property(t => t.TrgID).HasColumnName("TrgID");
            this.Property(t => t.TrgName).HasColumnName("TrgName");
            this.Property(t => t.TrgDescription).HasColumnName("TrgDescription");
            this.Property(t => t.Duration).HasColumnName("Duration");
            this.Property(t => t.PreTest).HasColumnName("PreTest");
            this.Property(t => t.PostTest).HasColumnName("PostTest");
            this.Property(t => t.TrainerID).HasColumnName("TrainerID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Purpose).HasColumnName("Purpose");
            this.Property(t => t.Objective).HasColumnName("Objective");
            this.Property(t => t.Agenda).HasColumnName("Agenda");
            this.Property(t => t.Deliverable).HasColumnName("Deliverable");
            this.Property(t => t.Pre).HasColumnName("Pre");
            this.Property(t => t.Success).HasColumnName("Success");
            this.Property(t => t.SubCategory).HasColumnName("SubCategory");
        }
    }
}
