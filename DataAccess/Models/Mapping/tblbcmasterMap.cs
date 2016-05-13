using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblbcmasterMap : EntityTypeConfiguration<tblbcmaster>
    {
        public tblbcmasterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Category)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblbcmaster");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
        }
    }
}
