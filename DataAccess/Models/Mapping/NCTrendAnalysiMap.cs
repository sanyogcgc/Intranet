using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCTrendAnalysiMap : EntityTypeConfiguration<NCTrendAnalysi>
    {
        public NCTrendAnalysiMap()
        {
            // Primary Key
            this.HasKey(t => t.Project_Id);

            // Properties
            this.Property(t => t.Project_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NCTrendAnalysis");
            this.Property(t => t.Project_Id).HasColumnName("Project_Id");
            this.Property(t => t.Q1_Major).HasColumnName("Q1_Major");
            this.Property(t => t.Q1_Minor).HasColumnName("Q1_Minor");
            this.Property(t => t.Q1_Observation).HasColumnName("Q1_Observation");
            this.Property(t => t.Q1_GoodObservation).HasColumnName("Q1_GoodObservation");
            this.Property(t => t.Q1_NoOfNCs).HasColumnName("Q1_NoOfNCs");
            this.Property(t => t.Q2_Major).HasColumnName("Q2_Major");
            this.Property(t => t.Q2_Minor).HasColumnName("Q2_Minor");
            this.Property(t => t.Q2_Observation).HasColumnName("Q2_Observation");
            this.Property(t => t.Q2_GoodObservation).HasColumnName("Q2_GoodObservation");
            this.Property(t => t.Q2_NoOfNCs).HasColumnName("Q2_NoOfNCs");
            this.Property(t => t.Q3_Major).HasColumnName("Q3_Major");
            this.Property(t => t.Q3_Minor).HasColumnName("Q3_Minor");
            this.Property(t => t.Q3_Observation).HasColumnName("Q3_Observation");
            this.Property(t => t.Q3_GoodObservation).HasColumnName("Q3_GoodObservation");
            this.Property(t => t.Q3_NoOfNCs).HasColumnName("Q3_NoOfNCs");
            this.Property(t => t.Q4_Major).HasColumnName("Q4_Major");
            this.Property(t => t.Q4_Minor).HasColumnName("Q4_Minor");
            this.Property(t => t.Q4_Observation).HasColumnName("Q4_Observation");
            this.Property(t => t.Q4_GoodObservation).HasColumnName("Q4_GoodObservation");
            this.Property(t => t.Q4_NoOfNCs).HasColumnName("Q4_NoOfNCs");
        }
    }
}
