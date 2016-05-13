using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PrjTypeMap : EntityTypeConfiguration<PrjType>
    {
        public PrjTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.pTypeId);

            // Properties
            this.Property(t => t.pTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PrjType");
            this.Property(t => t.pTypeId).HasColumnName("pTypeId");
            this.Property(t => t.pTypeName).HasColumnName("pTypeName");
        }
    }
}
