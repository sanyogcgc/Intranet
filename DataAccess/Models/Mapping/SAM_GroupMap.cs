using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SAM_GroupMap : EntityTypeConfiguration<SAM_Group>
    {
        public SAM_GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.SAM_Group_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SAM_Group");
            this.Property(t => t.SAM_Group_ID).HasColumnName("SAM_Group_ID");
            this.Property(t => t.Group_ID).HasColumnName("Group_ID");
            this.Property(t => t.Emp_ID).HasColumnName("Emp_ID");
        }
    }
}
