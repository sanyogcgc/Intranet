using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CommunicationMap : EntityTypeConfiguration<Communication>
    {
        public CommunicationMap()
        {
            // Primary Key
            this.HasKey(t => t.CommId);

            // Properties
            this.Property(t => t.CommId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CommType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Communication");
            this.Property(t => t.CommId).HasColumnName("CommId");
            this.Property(t => t.CommType).HasColumnName("CommType");
        }
    }
}
