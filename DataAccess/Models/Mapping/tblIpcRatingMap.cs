using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblIpcRatingMap : EntityTypeConfiguration<tblIpcRating>
    {
        public tblIpcRatingMap()
        {
            // Primary Key
            this.HasKey(t => t.Rating_Id);

            // Properties
            this.Property(t => t.Rate_Desc)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblIpcRating");
            this.Property(t => t.Rating_Id).HasColumnName("Rating_Id");
            this.Property(t => t.Rate_Desc).HasColumnName("Rate_Desc");
        }
    }
}
