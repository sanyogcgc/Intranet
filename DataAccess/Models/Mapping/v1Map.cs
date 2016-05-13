using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class v1Map : EntityTypeConfiguration<v1>
    {
        public v1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Emp_id, t.ID });

            // Properties
            this.Property(t => t.Emp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fname)
                .HasMaxLength(50);

            this.Property(t => t.Project_Name)
                .HasMaxLength(500);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("v1");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Project_Name).HasColumnName("Project_Name");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.ProjStatus).HasColumnName("ProjStatus");
        }
    }
}
