using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblIpcSubcatMap : EntityTypeConfiguration<tblIpcSubcat>
    {
        public tblIpcSubcatMap()
        {
            // Primary Key
            this.HasKey(t => t.Subcatt_Id);

            // Properties
            this.Property(t => t.Subcat_Desc)
                .HasMaxLength(50);

            this.Property(t => t.Cat_Id)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tblIpcSubcat");
            this.Property(t => t.Subcatt_Id).HasColumnName("Subcatt_Id");
            this.Property(t => t.Subcat_Desc).HasColumnName("Subcat_Desc");
            this.Property(t => t.Cat_Id).HasColumnName("Cat_Id");
        }
    }
}
