using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ViewProjectMap : EntityTypeConfiguration<ViewProject>
    {
        public ViewProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Project_Name)
                .HasMaxLength(500);

            this.Property(t => t.Client_Name)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectCode)
                .HasMaxLength(50);

            this.Property(t => t.PhaseName)
                .HasMaxLength(50);

            this.Property(t => t.Unit_name)
                .HasMaxLength(50);

            this.Property(t => t.Fname)
                .HasMaxLength(50);

            this.Property(t => t.Lname)
                .HasMaxLength(50);

            this.Property(t => t.spoc1)
                .HasMaxLength(50);

            this.Property(t => t.spoc2)
                .HasMaxLength(50);

            this.Property(t => t.am1)
                .HasMaxLength(50);

            this.Property(t => t.am2)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewProject");
            this.Property(t => t.pTypeId).HasColumnName("pTypeId");
            this.Property(t => t.pSubTypeId).HasColumnName("pSubTypeId");
            this.Property(t => t.Unit_id).HasColumnName("Unit_id");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.Project_Name).HasColumnName("Project_Name");
            this.Property(t => t.Client_Name).HasColumnName("Client_Name");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProjectCode).HasColumnName("ProjectCode");
            this.Property(t => t.PhaseName).HasColumnName("PhaseName");
            this.Property(t => t.Unit_name).HasColumnName("Unit_name");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Lname).HasColumnName("Lname");
            this.Property(t => t.spoc1).HasColumnName("spoc1");
            this.Property(t => t.spoc2).HasColumnName("spoc2");
            this.Property(t => t.am1).HasColumnName("am1");
            this.Property(t => t.am2).HasColumnName("am2");
        }
    }
}
