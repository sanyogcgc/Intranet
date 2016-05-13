using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class vw_WorkLogDefaulterMap : EntityTypeConfiguration<vw_WorkLogDefaulter>
    {
        public vw_WorkLogDefaulterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Emp_id, t.emailid });

            // Properties
            this.Property(t => t.Emp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.defaulter)
                .HasMaxLength(101);

            this.Property(t => t.emailid)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vw_WorkLogDefaulter");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.defaulter).HasColumnName("defaulter");
            this.Property(t => t.emailid).HasColumnName("emailid");
        }
    }
}
