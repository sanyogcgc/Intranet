using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class SChildLinkMap : EntityTypeConfiguration<SChildLink>
    {
        public SChildLinkMap()
        {
            // Primary Key
            this.HasKey(t => t.Child_Links_ID);

            // Properties
            this.Property(t => t.Child_Text)
                .HasMaxLength(50);

            this.Property(t => t.Child_URL)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SChildLinks");
            this.Property(t => t.Child_Links_ID).HasColumnName("Child_Links_ID");
            this.Property(t => t.Parent_Link_ID).HasColumnName("Parent_Link_ID");
            this.Property(t => t.Child_Text).HasColumnName("Child_Text");
            this.Property(t => t.Child_URL).HasColumnName("Child_URL");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
