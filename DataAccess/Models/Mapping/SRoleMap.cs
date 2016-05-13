using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SRoleMap : EntityTypeConfiguration<SRole>
    {
        public SRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Role_ID);

            // Properties
            this.Property(t => t.Role_Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SRoles");
            this.Property(t => t.Role_ID).HasColumnName("Role_ID");
            this.Property(t => t.Role_Name).HasColumnName("Role_Name");
        }
    }
}
