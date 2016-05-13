using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ReceptionANDLibraryMap : EntityTypeConfiguration<ReceptionANDLibrary>
    {
        public ReceptionANDLibraryMap()
        {
            // Primary Key
            this.HasKey(t => t.EmpID);

            // Properties
            this.Property(t => t.EmpID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReceptionANDLibrary");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
        }
    }
}
