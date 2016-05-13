using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SAM_RoleMap : EntityTypeConfiguration<SAM_Role>
    {
        public SAM_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.SAM_Role_Slno);

            // Properties
            // Table & Column Mappings
            this.ToTable("SAM_Role");
            this.Property(t => t.SAM_Role_Slno).HasColumnName("SAM_Role_Slno");
            this.Property(t => t.Role_ID).HasColumnName("Role_ID");
            this.Property(t => t.Group_ID).HasColumnName("Group_ID");
            this.Property(t => t.Emp_ID).HasColumnName("Emp_ID");
        }
    }
}
