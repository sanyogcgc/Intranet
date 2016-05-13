using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class AccessRightMap : EntityTypeConfiguration<AccessRight>
    {
        public AccessRightMap()
        {
            // Primary Key
            this.HasKey(t => t.security_id);

            // Properties
            this.Property(t => t.security_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccessRights");
            this.Property(t => t.security_id).HasColumnName("security_id");
            this.Property(t => t.TarList).HasColumnName("TarList");
            this.Property(t => t.AddNewTar).HasColumnName("AddNewTar");
            this.Property(t => t.MyProfile).HasColumnName("MyProfile");
            this.Property(t => t.Reports).HasColumnName("Reports");
            this.Property(t => t.ReleasedNotes).HasColumnName("ReleasedNotes");
            this.Property(t => t.Administration).HasColumnName("Administration");
        }
    }
}
