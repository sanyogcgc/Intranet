using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW1Map : EntityTypeConfiguration<VIEW1>
    {
        public VIEW1Map()
        {
            // Primary Key
            this.HasKey(t => t.sno);

            // Properties
            this.Property(t => t.sno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.Project_Name)
                .HasMaxLength(500);

            this.Property(t => t.PhaseName)
                .HasMaxLength(50);

            this.Property(t => t.status)
                .HasMaxLength(4000);

            this.Property(t => t.systime)
                .HasMaxLength(50);

            this.Property(t => t.Unit_name)
                .HasMaxLength(50);

            this.Property(t => t.Client_Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VIEW1");
            this.Property(t => t.date1).HasColumnName("date1");
            this.Property(t => t.sno).HasColumnName("sno");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Project_Name).HasColumnName("Project_Name");
            this.Property(t => t.PhaseName).HasColumnName("PhaseName");
            this.Property(t => t.hours).HasColumnName("hours");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.systime).HasColumnName("systime");
            this.Property(t => t.Unit_name).HasColumnName("Unit_name");
            this.Property(t => t.Client_Name).HasColumnName("Client_Name");
        }
    }
}
