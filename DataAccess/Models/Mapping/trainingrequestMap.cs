using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class trainingrequestMap : EntityTypeConfiguration<trainingrequest>
    {
        public trainingrequestMap()
        {
            // Primary Key
            this.HasKey(t => t.UID);

            // Properties
            this.Property(t => t.Priority)
                .HasMaxLength(50);

            this.Property(t => t.Department)
                .HasMaxLength(50);

            this.Property(t => t.Subject)
                .HasMaxLength(150);

            this.Property(t => t.Comments)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("trainingrequest");
            this.Property(t => t.UID).HasColumnName("UID");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
