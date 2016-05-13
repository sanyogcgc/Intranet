using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class RockStarForBUHMap : EntityTypeConfiguration<RockStarForBUH>
    {
        public RockStarForBUHMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UidBuh, t.Unit, t.Emp_id, t.BhuEmp_id, t.supervisor, t.Description1, t.Description2, t.Description3, t.Description4, t.Description5, t.Description6, t.Description7, t.Awards, t.Quarter, t.CreateDate });

            // Properties
            this.Property(t => t.UidBuh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Unit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Emp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BhuEmp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.supervisor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description1)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Description2)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Description3)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Description4)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Description5)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Description6)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Description7)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Awards)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Quarter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RockStarForBUH");
            this.Property(t => t.UidBuh).HasColumnName("UidBuh");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.BhuEmp_id).HasColumnName("BhuEmp_id");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.Description1).HasColumnName("Description1");
            this.Property(t => t.Description2).HasColumnName("Description2");
            this.Property(t => t.Description3).HasColumnName("Description3");
            this.Property(t => t.Description4).HasColumnName("Description4");
            this.Property(t => t.Description5).HasColumnName("Description5");
            this.Property(t => t.Description6).HasColumnName("Description6");
            this.Property(t => t.Description7).HasColumnName("Description7");
            this.Property(t => t.Awards).HasColumnName("Awards");
            this.Property(t => t.Quarter).HasColumnName("Quarter");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
