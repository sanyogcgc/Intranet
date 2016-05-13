using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class prjsubtypeMap : EntityTypeConfiguration<prjsubtype>
    {
        public prjsubtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.pSubTypeId);

            // Properties
            this.Property(t => t.SubTypeDesc)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("prjsubtype");
            this.Property(t => t.pSubTypeId).HasColumnName("pSubTypeId");
            this.Property(t => t.pTypeId).HasColumnName("pTypeId");
            this.Property(t => t.SubTypeDesc).HasColumnName("SubTypeDesc");
        }
    }
}
