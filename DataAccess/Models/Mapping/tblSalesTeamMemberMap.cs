using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblSalesTeamMemberMap : EntityTypeConfiguration<tblSalesTeamMember>
    {
        public tblSalesTeamMemberMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SerialNo, t.TeamId, t.BDId });

            // Properties
            this.Property(t => t.SerialNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TeamId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BDId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblSalesTeamMembers");
            this.Property(t => t.SerialNo).HasColumnName("SerialNo");
            this.Property(t => t.TeamId).HasColumnName("TeamId");
            this.Property(t => t.BDId).HasColumnName("BDId");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
