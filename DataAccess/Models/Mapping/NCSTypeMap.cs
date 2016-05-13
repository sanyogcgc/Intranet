using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCSTypeMap : EntityTypeConfiguration<NCSType>
    {
        public NCSTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.NCTypeID);

            // Properties
            this.Property(t => t.NCTypeName)
                .HasMaxLength(50);

            this.Property(t => t.NCTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NCSType");
            this.Property(t => t.NCTypeName).HasColumnName("NCTypeName");
            this.Property(t => t.NCTypeID).HasColumnName("NCTypeID");
        }
    }
}
