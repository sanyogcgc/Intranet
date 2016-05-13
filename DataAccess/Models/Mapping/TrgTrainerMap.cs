using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgTrainerMap : EntityTypeConfiguration<TrgTrainer>
    {
        public TrgTrainerMap()
        {
            // Primary Key
            this.HasKey(t => t.TrainerID);

            // Properties
            this.Property(t => t.TrainerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TrainerName)
                .HasMaxLength(100);

            this.Property(t => t.TrainerOrganization)
                .HasMaxLength(100);

            this.Property(t => t.Comments)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("TrgTrainer");
            this.Property(t => t.TrainerID).HasColumnName("TrainerID");
            this.Property(t => t.TrainerName).HasColumnName("TrainerName");
            this.Property(t => t.TrainerExp).HasColumnName("TrainerExp");
            this.Property(t => t.TrainerOrganization).HasColumnName("TrainerOrganization");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
