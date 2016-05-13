using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tbl_Resoure_Non_DefaulterMap : EntityTypeConfiguration<tbl_Resoure_Non_Defaulter>
    {
        public tbl_Resoure_Non_DefaulterMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeId);

            // Properties
            this.Property(t => t.EmployeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tbl_Resoure_Non_Defaulter");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
        }
    }
}
