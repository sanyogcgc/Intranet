using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SGroupMap : EntityTypeConfiguration<SGroup>
    {
        public SGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Group_ID);

            // Properties
            this.Property(t => t.Group_Name)
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("SGroups");
            this.Property(t => t.Group_ID).HasColumnName("Group_ID");
            this.Property(t => t.Group_Name).HasColumnName("Group_Name");
        }
    }
}
