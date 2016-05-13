using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgScheduleMap : EntityTypeConfiguration<TrgSchedule>
    {
        public TrgScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.TrgSchID);

            // Properties
            this.Property(t => t.TrgSchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TrgSchTime)
                .HasMaxLength(50);

            this.Property(t => t.TimeFrom)
                .HasMaxLength(50);

            this.Property(t => t.TimeTo)
                .HasMaxLength(50);

            this.Property(t => t.TrainerName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrgSchedule");
            this.Property(t => t.TrgSchID).HasColumnName("TrgSchID");
            this.Property(t => t.TrgID).HasColumnName("TrgID");
            this.Property(t => t.TrgSchDate).HasColumnName("TrgSchDate");
            this.Property(t => t.TrgSchTime).HasColumnName("TrgSchTime");
            this.Property(t => t.TrgVnuID).HasColumnName("TrgVnuID");
            this.Property(t => t.TrgSchCutoffDate).HasColumnName("TrgSchCutoffDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.DateFrom).HasColumnName("DateFrom");
            this.Property(t => t.DateTo).HasColumnName("DateTo");
            this.Property(t => t.TimeFrom).HasColumnName("TimeFrom");
            this.Property(t => t.TimeTo).HasColumnName("TimeTo");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
            this.Property(t => t.TrainerID).HasColumnName("TrainerID");
            this.Property(t => t.TrainerName).HasColumnName("TrainerName");
        }
    }
}
