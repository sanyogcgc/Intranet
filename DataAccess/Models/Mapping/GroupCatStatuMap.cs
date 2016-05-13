using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class GroupCatStatuMap : EntityTypeConfiguration<GroupCatStatu>
    {
        public GroupCatStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusId);

            // Properties
            this.Property(t => t.StatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GroupCatStatus");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
