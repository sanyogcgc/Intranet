using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tb_trainee_feedbackMap : EntityTypeConfiguration<tb_trainee_feedback>
    {
        public tb_trainee_feedbackMap()
        {
            // Primary Key
            this.HasKey(t => t.FID);

            // Properties
            this.Property(t => t.Training)
                .HasMaxLength(500);

            this.Property(t => t.trainer_name)
                .HasMaxLength(500);

            this.Property(t => t.imp_tra)
                .HasMaxLength(50);

            this.Property(t => t.com_obj)
                .HasMaxLength(50);

            this.Property(t => t.clarity_cov)
                .HasMaxLength(50);

            this.Property(t => t.pace_pres)
                .HasMaxLength(50);

            this.Property(t => t.covera_mater)
                .HasMaxLength(50);

            this.Property(t => t.clarity_commu)
                .HasMaxLength(50);

            this.Property(t => t.prserna_trainer)
                .HasMaxLength(50);

            this.Property(t => t.knowedge_trainer)
                .HasMaxLength(50);

            this.Property(t => t.question_handling)
                .HasMaxLength(50);

            this.Property(t => t.overall_effect)
                .HasMaxLength(50);

            this.Property(t => t.time_training)
                .HasMaxLength(50);

            this.Property(t => t.training_session)
                .HasMaxLength(50);

            this.Property(t => t.content_used)
                .HasMaxLength(50);

            this.Property(t => t.overall_programme)
                .HasMaxLength(50);

            this.Property(t => t.repaeat_session)
                .HasMaxLength(500);

            this.Property(t => t.like_session)
                .HasMaxLength(500);

            this.Property(t => t.dislike_session)
                .HasMaxLength(500);

            this.Property(t => t.key_learningq)
                .HasMaxLength(500);

            this.Property(t => t.suggest_programme)
                .HasMaxLength(500);

            this.Property(t => t.Rating)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tb_trainee_feedback");
            this.Property(t => t.FID).HasColumnName("FID");
            this.Property(t => t.empp_id).HasColumnName("empp_id");
            this.Property(t => t.Training).HasColumnName("Training");
            this.Property(t => t.trainer_name).HasColumnName("trainer_name");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.imp_tra).HasColumnName("imp_tra");
            this.Property(t => t.com_obj).HasColumnName("com_obj");
            this.Property(t => t.clarity_cov).HasColumnName("clarity_cov");
            this.Property(t => t.pace_pres).HasColumnName("pace_pres");
            this.Property(t => t.covera_mater).HasColumnName("covera_mater");
            this.Property(t => t.clarity_commu).HasColumnName("clarity_commu");
            this.Property(t => t.prserna_trainer).HasColumnName("prserna_trainer");
            this.Property(t => t.knowedge_trainer).HasColumnName("knowedge_trainer");
            this.Property(t => t.question_handling).HasColumnName("question_handling");
            this.Property(t => t.overall_effect).HasColumnName("overall_effect");
            this.Property(t => t.time_training).HasColumnName("time_training");
            this.Property(t => t.training_session).HasColumnName("training_session");
            this.Property(t => t.content_used).HasColumnName("content_used");
            this.Property(t => t.overall_programme).HasColumnName("overall_programme");
            this.Property(t => t.repaeat_session).HasColumnName("repaeat_session");
            this.Property(t => t.like_session).HasColumnName("like_session");
            this.Property(t => t.dislike_session).HasColumnName("dislike_session");
            this.Property(t => t.key_learningq).HasColumnName("key_learningq");
            this.Property(t => t.suggest_programme).HasColumnName("suggest_programme");
            this.Property(t => t.Rating).HasColumnName("Rating");
        }
    }
}
