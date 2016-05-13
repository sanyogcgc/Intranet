using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblSalesTeamMasterMap : EntityTypeConfiguration<tblSalesTeamMaster>
    {
        public tblSalesTeamMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.TeamId);

            // Properties
            this.Property(t => t.TeamName)
                .HasMaxLength(100);

            this.Property(t => t.SalesTeamhead)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblSalesTeamMaster");
            this.Property(t => t.TeamId).HasColumnName("TeamId");
            this.Property(t => t.TeamName).HasColumnName("TeamName");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
            this.Property(t => t.SalesTeamhead).HasColumnName("SalesTeamhead");
        }
    }
}
