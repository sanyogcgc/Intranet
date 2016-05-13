using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SParent_LinksMap : EntityTypeConfiguration<SParent_Links>
    {
        public SParent_LinksMap()
        {
            // Primary Key
            this.HasKey(t => t.Link_Parent_ID);

            // Properties
            this.Property(t => t.Parent_Name)
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("SParent_Links");
            this.Property(t => t.Link_Parent_ID).HasColumnName("Link_Parent_ID");
            this.Property(t => t.Parent_Name).HasColumnName("Parent_Name");
            this.Property(t => t.Priority).HasColumnName("Priority");
        }
    }
}
