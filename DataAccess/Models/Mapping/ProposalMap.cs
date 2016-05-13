using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProposalMap : EntityTypeConfiguration<Proposal>
    {
        public ProposalMap()
        {
            // Primary Key
            this.HasKey(t => t.ProId);

            // Properties
            this.Property(t => t.Worth)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Proposal");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.ProDate).HasColumnName("ProDate");
            this.Property(t => t.CurId).HasColumnName("CurId");
            this.Property(t => t.Worth).HasColumnName("Worth");
            this.Property(t => t.pid).HasColumnName("pid");
        }
    }
}
