using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class GroupUserMappingMap : EntityTypeConfiguration<GroupUserMapping>
    {
        public GroupUserMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.Userid);

            // Properties
            this.Property(t => t.Userid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GroupUserMapping");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Groupid).HasColumnName("Groupid");
        }
    }
}
