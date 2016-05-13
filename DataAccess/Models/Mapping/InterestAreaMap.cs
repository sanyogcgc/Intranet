using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class InterestAreaMap : EntityTypeConfiguration<InterestArea>
    {
        public InterestAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.InterestAreaID);

            // Properties
            this.Property(t => t.InterestArea1)
                .HasMaxLength(8000);

            this.Property(t => t.Description)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("InterestArea");
            this.Property(t => t.InterestAreaID).HasColumnName("InterestAreaID");
            this.Property(t => t.InterestArea1).HasColumnName("InterestArea");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
