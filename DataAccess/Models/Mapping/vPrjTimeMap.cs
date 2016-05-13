using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vPrjTimeMap : EntityTypeConfiguration<vPrjTime>
    {
        public vPrjTimeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PhaseId, t.ID, t.pid, t.Unit_id });

            // Properties
            this.Property(t => t.ManDays)
                .HasMaxLength(50);

            this.Property(t => t.PhaseName)
                .HasMaxLength(50);

            this.Property(t => t.PhaseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Client_Name)
                .HasMaxLength(50);

            this.Property(t => t.Project_Name)
                .HasMaxLength(500);

            this.Property(t => t.pid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Group_Name)
                .HasMaxLength(75);

            this.Property(t => t.Unit_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Unit_name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vPrjTime");
            this.Property(t => t.ManDays).HasColumnName("ManDays");
            this.Property(t => t.PhaseName).HasColumnName("PhaseName");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Client_Name).HasColumnName("Client_Name");
            this.Property(t => t.Starting_Date).HasColumnName("Starting_Date");
            this.Property(t => t.Project_Name).HasColumnName("Project_Name");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.Group_Name).HasColumnName("Group_Name");
            this.Property(t => t.subphaseid).HasColumnName("subphaseid");
            this.Property(t => t.Unit_id).HasColumnName("Unit_id");
            this.Property(t => t.Unit_name).HasColumnName("Unit_name");
        }
    }
}
