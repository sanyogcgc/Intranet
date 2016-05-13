using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class IParentLinkMap : EntityTypeConfiguration<IParentLink>
    {
        public IParentLinkMap()
        {
            // Primary Key
            this.HasKey(t => t.Parent_ID);

            // Properties
            this.Property(t => t.Parent_link)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("IParentLink");
            this.Property(t => t.Parent_ID).HasColumnName("Parent_ID");
            this.Property(t => t.Parent_link).HasColumnName("Parent_link");
            this.Property(t => t.priority).HasColumnName("priority");
        }
    }
}
