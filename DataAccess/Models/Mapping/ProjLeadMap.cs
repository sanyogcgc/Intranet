using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProjLeadMap : EntityTypeConfiguration<ProjLead>
    {
        public ProjLeadMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjLead_Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProjLead");
            this.Property(t => t.ProjLead_Id).HasColumnName("ProjLead_Id");
            this.Property(t => t.TeamLeader).HasColumnName("TeamLeader");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
        }
    }
}
