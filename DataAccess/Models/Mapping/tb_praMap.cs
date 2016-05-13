using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tb_praMap : EntityTypeConfiguration<tb_pra>
    {
        public tb_praMap()
        {
            // Primary Key
            this.HasKey(t => t.PRAID);

            // Properties
            this.Property(t => t.year)
                .HasMaxLength(50);

            this.Property(t => t.month)
                .HasMaxLength(50);

            this.Property(t => t.comments)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("tb_pra");
            this.Property(t => t.PRAID).HasColumnName("PRAID");
            this.Property(t => t.EMPID).HasColumnName("EMPID");
            this.Property(t => t.Rmempid).HasColumnName("Rmempid");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.month).HasColumnName("month");
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
            this.Property(t => t.Average).HasColumnName("Average");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
        }
    }
}
