using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tb_praStatusMap : EntityTypeConfiguration<tb_praStatus>
    {
        public tb_praStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.clientSatisfaction)
                .HasMaxLength(250);

            this.Property(t => t.clientIntrenalCommu)
                .HasMaxLength(250);

            this.Property(t => t.Errorfree)
                .HasMaxLength(250);

            this.Property(t => t.utilization)
                .HasMaxLength(250);

            this.Property(t => t.problrlSolving)
                .HasMaxLength(250);

            this.Property(t => t.Attitude)
                .HasMaxLength(250);

            this.Property(t => t.Initiatives)
                .HasMaxLength(250);

            this.Property(t => t.Discipline)
                .HasMaxLength(250);

            this.Property(t => t.openness)
                .HasMaxLength(250);

            this.Property(t => t.participate)
                .HasMaxLength(250);

            this.Property(t => t.Learning)
                .HasMaxLength(250);

            this.Property(t => t.knoowledge)
                .HasMaxLength(250);

            this.Property(t => t.managinExpectation)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("tb_praStatus");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.clientSatisfaction).HasColumnName("clientSatisfaction");
            this.Property(t => t.clientIntrenalCommu).HasColumnName("clientIntrenalCommu");
            this.Property(t => t.Errorfree).HasColumnName("Errorfree");
            this.Property(t => t.utilization).HasColumnName("utilization");
            this.Property(t => t.problrlSolving).HasColumnName("problrlSolving");
            this.Property(t => t.Attitude).HasColumnName("Attitude");
            this.Property(t => t.Initiatives).HasColumnName("Initiatives");
            this.Property(t => t.Discipline).HasColumnName("Discipline");
            this.Property(t => t.openness).HasColumnName("openness");
            this.Property(t => t.participate).HasColumnName("participate");
            this.Property(t => t.Learning).HasColumnName("Learning");
            this.Property(t => t.knoowledge).HasColumnName("knoowledge");
            this.Property(t => t.managinExpectation).HasColumnName("managinExpectation");
        }
    }
}
