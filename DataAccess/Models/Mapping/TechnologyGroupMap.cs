using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
namespace DataAccess.Models.Mapping
{
    public class TechnologyGroupMap:EntityTypeConfiguration<TechnologyGroup>
    {
        public TechnologyGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            //Properties
            // Table & Column Mappings
            this.ToTable("TechnologyGroup");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Technology_Name).HasColumnName("Technology_Name");
            this.Property(t => t.Status).HasColumnName("Status");


        }
    }
}
