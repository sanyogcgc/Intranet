using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjMemberMap : EntityTypeConfiguration<ProjMember>
    {
        public ProjMemberMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjMember_Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProjMember");
            this.Property(t => t.ProjMember_Id).HasColumnName("ProjMember_Id");
            this.Property(t => t.TeamMember).HasColumnName("TeamMember");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
        }
    }
}
