using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_Project_Audit_NCMap : EntityTypeConfiguration<vw_Project_Audit_NC>
    {
        public vw_Project_Audit_NCMap()
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
            this.ToTable("vw_Project_Audit_NC");
            this.Property(t => t.Audit_Id).HasColumnName("Audit_Id");
            this.Property(t => t.NoOfNCs).HasColumnName("NoOfNCs");
            this.Property(t => t.Major).HasColumnName("Major");
            this.Property(t => t.Minor).HasColumnName("Minor");
            this.Property(t => t.Observation).HasColumnName("Observation");
            this.Property(t => t.GoodObservation).HasColumnName("GoodObservation");
        }
    }
}
