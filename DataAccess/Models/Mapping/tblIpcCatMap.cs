using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblIpcCatMap : EntityTypeConfiguration<tblIpcCat>
    {
        public tblIpcCatMap()
        {
            // Primary Key
            this.HasKey(t => t.Cat_ID);

            // Properties
            this.Property(t => t.Cat_Desc)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblIpcCat");
            this.Property(t => t.Cat_ID).HasColumnName("Cat_ID");
            this.Property(t => t.Cat_Desc).HasColumnName("Cat_Desc");
        }
    }
}
