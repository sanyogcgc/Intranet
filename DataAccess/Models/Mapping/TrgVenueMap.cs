using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgVenueMap : EntityTypeConfiguration<TrgVenue>
    {
        public TrgVenueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VenueID, t.VenueName });

            // Properties
            this.Property(t => t.VenueID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VenueName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.VenueDesc)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("TrgVenue");
            this.Property(t => t.VenueID).HasColumnName("VenueID");
            this.Property(t => t.VenueName).HasColumnName("VenueName");
            this.Property(t => t.VenueDesc).HasColumnName("VenueDesc");
            this.Property(t => t.Capicity).HasColumnName("Capicity");
            this.Property(t => t.WhiteBoard).HasColumnName("WhiteBoard");
            this.Property(t => t.Projector).HasColumnName("Projector");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
