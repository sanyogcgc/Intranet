using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class traing_linkTableMap : EntityTypeConfiguration<traing_linkTable>
    {
        public traing_linkTableMap()
        {
            // Primary Key
            this.HasKey(t => t.linkiD);

            // Properties
            // Table & Column Mappings
            this.ToTable("traing_linkTable");
            this.Property(t => t.linkiD).HasColumnName("linkiD");
            this.Property(t => t.TC_ID).HasColumnName("TC_ID");
            this.Property(t => t.participantsID).HasColumnName("participantsID");
        }
    }
}
