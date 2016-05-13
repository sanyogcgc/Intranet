using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tb_trainer_feedbackMap : EntityTypeConfiguration<tb_trainer_feedback>
    {
        public tb_trainer_feedbackMap()
        {
            // Primary Key
            this.HasKey(t => t.FID);

            // Properties
            this.Property(t => t.Training)
                .HasMaxLength(500);

            this.Property(t => t.trainer_name)
                .HasMaxLength(500);

            this.Property(t => t.overall_trainig)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.complete_objective)
                .HasMaxLength(50);

            this.Property(t => t.group_enganement)
                .HasMaxLength(50);

            this.Property(t => t.listning_particiopents)
                .HasMaxLength(50);

            this.Property(t => t.overall_effectiveness)
                .HasMaxLength(50);

            this.Property(t => t.time_training)
                .HasMaxLength(50);

            this.Property(t => t.training_session)
                .HasMaxLength(50);

            this.Property(t => t.overall_programme)
                .HasMaxLength(50);

            this.Property(t => t.like_seesion)
                .HasMaxLength(500);

            this.Property(t => t.dislike_session)
                .HasMaxLength(500);

            this.Property(t => t.suggest_traing_priogram)
                .HasMaxLength(500);

            this.Property(t => t.Rating)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tb_trainer_feedback");
            this.Property(t => t.FID).HasColumnName("FID");
            this.Property(t => t.TC_ID).HasColumnName("TC_ID");
            this.Property(t => t.Training).HasColumnName("Training");
            this.Property(t => t.trainer_name).HasColumnName("trainer_name");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.overall_trainig).HasColumnName("overall_trainig");
            this.Property(t => t.complete_objective).HasColumnName("complete_objective");
            this.Property(t => t.group_enganement).HasColumnName("group_enganement");
            this.Property(t => t.listning_particiopents).HasColumnName("listning_particiopents");
            this.Property(t => t.overall_effectiveness).HasColumnName("overall_effectiveness");
            this.Property(t => t.time_training).HasColumnName("time_training");
            this.Property(t => t.training_session).HasColumnName("training_session");
            this.Property(t => t.overall_programme).HasColumnName("overall_programme");
            this.Property(t => t.like_seesion).HasColumnName("like_seesion");
            this.Property(t => t.dislike_session).HasColumnName("dislike_session");
            this.Property(t => t.suggest_traing_priogram).HasColumnName("suggest_traing_priogram");
            this.Property(t => t.Rating).HasColumnName("Rating");
        }
    }
}
