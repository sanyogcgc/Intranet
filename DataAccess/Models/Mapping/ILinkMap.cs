using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ILinkMap : EntityTypeConfiguration<ILink>
    {
        public ILinkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Link_ID, t.Link_Text, t.Link_URL, t.Group_ID, t.Activate_Bit });

            // Properties
            this.Property(t => t.Link_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Link_Text)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Link_URL)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Group_ID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ILinks");
            this.Property(t => t.Link_ID).HasColumnName("Link_ID");
            this.Property(t => t.Parent_ID).HasColumnName("Parent_ID");
            this.Property(t => t.Link_Text).HasColumnName("Link_Text");
            this.Property(t => t.Link_URL).HasColumnName("Link_URL");
            this.Property(t => t.Group_ID).HasColumnName("Group_ID");
            this.Property(t => t.Activate_Bit).HasColumnName("Activate_Bit");
            this.Property(t => t.priority).HasColumnName("priority");
        }
    }
}
