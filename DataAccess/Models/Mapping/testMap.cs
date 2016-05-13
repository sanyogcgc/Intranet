using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class testMap : EntityTypeConfiguration<test>
    {
        public testMap()
        {
            // Primary Key
            this.HasKey(t => t.EMPID);

            // Properties
            this.Property(t => t.EMPID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("test");
            this.Property(t => t.EMPID).HasColumnName("EMPID");
            this.Property(t => t.ForDate).HasColumnName("ForDate");
            this.Property(t => t.WORKHOURS).HasColumnName("WORKHOURS");
            this.Property(t => t.ProjId).HasColumnName("ProjId");
        }
    }
}
