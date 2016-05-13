using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PFReportMap : EntityTypeConfiguration<PFReport>
    {
        public PFReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TrgRegNo, t.TrgFbkEmpID });

            // Properties
            this.Property(t => t.Employee)
                .HasMaxLength(101);

            this.Property(t => t.Desig)
                .HasMaxLength(50);

            this.Property(t => t.TrgRegNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Invited)
                .HasMaxLength(50);

            this.Property(t => t.Attendance)
                .HasMaxLength(50);

            this.Property(t => t.TrgFbkEmpID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SessionObjective)
                .HasMaxLength(200);

            this.Property(t => t.FbkQuestion1)
                .HasMaxLength(200);

            this.Property(t => t.FbkQuestion2)
                .HasMaxLength(200);

            this.Property(t => t.FbkQuestion3)
                .HasMaxLength(200);

            this.Property(t => t.FbkQuestion4)
                .HasMaxLength(200);

            this.Property(t => t.FbkQuestion5)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("PFReport");
            this.Property(t => t.Employee).HasColumnName("Employee");
            this.Property(t => t.Desig).HasColumnName("Desig");
            this.Property(t => t.TrgRegNo).HasColumnName("TrgRegNo");
            this.Property(t => t.TrgSchID).HasColumnName("TrgSchID");
            this.Property(t => t.Invited).HasColumnName("Invited");
            this.Property(t => t.Attendance).HasColumnName("Attendance");
            this.Property(t => t.PreTestScore).HasColumnName("PreTestScore");
            this.Property(t => t.PostTestScore).HasColumnName("PostTestScore");
            this.Property(t => t.TrgFbkEmpID).HasColumnName("TrgFbkEmpID");
            this.Property(t => t.SessionObjective).HasColumnName("SessionObjective");
            this.Property(t => t.TopicEAOS1).HasColumnName("TopicEAOS1");
            this.Property(t => t.TopicEAOS2).HasColumnName("TopicEAOS2");
            this.Property(t => t.TopicEAOS3).HasColumnName("TopicEAOS3");
            this.Property(t => t.TopicEAOS4).HasColumnName("TopicEAOS4");
            this.Property(t => t.TopicEAOS5).HasColumnName("TopicEAOS5");
            this.Property(t => t.FbkoTrainer1).HasColumnName("FbkoTrainer1");
            this.Property(t => t.FbkoTrainer2).HasColumnName("FbkoTrainer2");
            this.Property(t => t.FbkoTrainer3).HasColumnName("FbkoTrainer3");
            this.Property(t => t.FbkoTrainer4).HasColumnName("FbkoTrainer4");
            this.Property(t => t.FbkoTrainer5).HasColumnName("FbkoTrainer5");
            this.Property(t => t.GeneralFbk1).HasColumnName("GeneralFbk1");
            this.Property(t => t.GeneralFbk2).HasColumnName("GeneralFbk2");
            this.Property(t => t.GeneralFbk3).HasColumnName("GeneralFbk3");
            this.Property(t => t.GeneralFbk4).HasColumnName("GeneralFbk4");
            this.Property(t => t.FbkQuestion1).HasColumnName("FbkQuestion1");
            this.Property(t => t.FbkQuestion2).HasColumnName("FbkQuestion2");
            this.Property(t => t.FbkQuestion3).HasColumnName("FbkQuestion3");
            this.Property(t => t.FbkQuestion4).HasColumnName("FbkQuestion4");
            this.Property(t => t.FbkQuestion5).HasColumnName("FbkQuestion5");
            this.Property(t => t.FbkGiven).HasColumnName("FbkGiven");
        }
    }
}
