using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblCatagoryMap : EntityTypeConfiguration<tblCatagory>
    {
        public tblCatagoryMap()
        {
            // Primary Key
            this.HasKey(t => t.CatagoryID);

            // Properties
            this.Property(t => t.CatagoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CatagoryName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblCatagory");
            this.Property(t => t.CatagoryID).HasColumnName("CatagoryID");
            this.Property(t => t.CatagoryName).HasColumnName("CatagoryName");
        }
    }
}
