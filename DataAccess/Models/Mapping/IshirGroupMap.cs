using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class IshirGroupMap : EntityTypeConfiguration<IshirGroup>
    {
        public IshirGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Groupid);

            // Properties
            this.Property(t => t.Groupname)
                .HasMaxLength(50);

            this.Property(t => t.EscalationEmailid)
                .HasMaxLength(50);

            this.Property(t => t.GroupleaderEmailid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IshirGroups");
            this.Property(t => t.EscalationHead).HasColumnName("EscalationHead");
            this.Property(t => t.Groupname).HasColumnName("Groupname");
            this.Property(t => t.Groupid).HasColumnName("Groupid");
            this.Property(t => t.Groupleaderid).HasColumnName("Groupleaderid");
            this.Property(t => t.EscalationEmailid).HasColumnName("EscalationEmailid");
            this.Property(t => t.GroupleaderEmailid).HasColumnName("GroupleaderEmailid");
        }
    }
}
