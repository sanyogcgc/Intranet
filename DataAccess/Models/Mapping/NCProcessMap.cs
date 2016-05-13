using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class NCProcessMap : EntityTypeConfiguration<NCProcess>
    {
        public NCProcessMap()
        {
            // Primary Key
            this.HasKey(t => t.Type_Id);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NCProcesses");
            this.Property(t => t.Type_Id).HasColumnName("Type_Id");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.ActiveFlag).HasColumnName("ActiveFlag");
        }
    }
}
