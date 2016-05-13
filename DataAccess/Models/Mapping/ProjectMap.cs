using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(500);

            this.Property(t => t.Project_Name)
                .HasMaxLength(500);

            this.Property(t => t.Phase)
                .HasMaxLength(50);

            this.Property(t => t.ProjectCode)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedTime)
                .HasMaxLength(15);

            this.Property(t => t.pm)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Projects");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Client_Code).HasColumnName("Client_Code");
            this.Property(t => t.Business_Developer).HasColumnName("Business_Developer");
            this.Property(t => t.Currency_Code).HasColumnName("Currency_Code");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Project_Name).HasColumnName("Project_Name");
            this.Property(t => t.Solution_Type).HasColumnName("Solution_Type");
            this.Property(t => t.Starting_Date).HasColumnName("Starting_Date");
            this.Property(t => t.Project_Cost).HasColumnName("Project_Cost");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.Phase).HasColumnName("Phase");
            this.Property(t => t.ProjectCode).HasColumnName("ProjectCode");
            this.Property(t => t.teamLeader).HasColumnName("teamLeader");
            this.Property(t => t.TeamLeader_Second).HasColumnName("TeamLeader_Second");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.spoc).HasColumnName("spoc");
            this.Property(t => t.pm).HasColumnName("pm");
            this.Property(t => t.currency_exchange_rate).HasColumnName("currency_exchange_rate");
            this.Property(t => t.TotalInr).HasColumnName("TotalInr");
            this.Property(t => t.TotalDollar).HasColumnName("TotalDollar");
            this.Property(t => t.intAccountManager).HasColumnName("intAccountManager");
            this.Property(t => t.ProposedEstEfforts).HasColumnName("ProposedEstEfforts");
            this.Property(t => t.ProjStatus).HasColumnName("ProjStatus");
            this.Property(t => t.IsBillable).HasColumnName("IsBillable");
        }
    }
}
