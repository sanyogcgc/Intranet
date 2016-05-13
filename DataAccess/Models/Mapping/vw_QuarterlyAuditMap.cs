using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_QuarterlyAuditMap : EntityTypeConfiguration<vw_QuarterlyAudit>
    {
        public vw_QuarterlyAuditMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Audit_Id, t.Major, t.Minor, t.Observation, t.GoodObservation });

            // Properties
            this.Property(t => t.Audit_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Major)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Minor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Observation)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GoodObservation)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vw_QuarterlyAudit");
            this.Property(t => t.Sch_Audit_Year).HasColumnName("Sch_Audit_Year");
            this.Property(t => t.Sch_Audit_Quarter).HasColumnName("Sch_Audit_Quarter");
            this.Property(t => t.Audit_Id).HasColumnName("Audit_Id");
            this.Property(t => t.Major).HasColumnName("Major");
            this.Property(t => t.Minor).HasColumnName("Minor");
            this.Property(t => t.Observation).HasColumnName("Observation");
            this.Property(t => t.GoodObservation).HasColumnName("GoodObservation");
            this.Property(t => t.NoOfNCs).HasColumnName("NoOfNCs");
        }
    }
}
