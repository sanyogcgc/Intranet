using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tb_prafeedbackMap : EntityTypeConfiguration<tb_prafeedback>
    {
        public tb_prafeedbackMap()
        {
            // Primary Key
            this.HasKey(t => t.feedbackid);

            // Properties
            this.Property(t => t.GivenBy)
                .HasMaxLength(150);

            this.Property(t => t.feedback)
                .HasMaxLength(1750);

            this.Property(t => t.status)
                .HasMaxLength(50);

            this.Property(t => t.type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tb_prafeedback");
            this.Property(t => t.feedbackid).HasColumnName("feedbackid");
            this.Property(t => t.empid).HasColumnName("empid");
            this.Property(t => t.rmempid).HasColumnName("rmempid");
            this.Property(t => t.GivenBy).HasColumnName("GivenBy");
            this.Property(t => t.feedback).HasColumnName("feedback");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.RMREMARKS).HasColumnName("RMREMARKS");
        }
    }
}
