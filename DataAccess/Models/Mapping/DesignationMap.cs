using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class DesignationMap : EntityTypeConfiguration<Designation>
    {
        public DesignationMap()
        {
            // Primary Key
            this.HasKey(t => t.Designation_id);

            // Properties
            this.Property(t => t.Designation_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Designation_name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Designation");
            this.Property(t => t.Designation_id).HasColumnName("Designation_id");
            this.Property(t => t.Designation_name).HasColumnName("Designation_name");
        }
    }
}
