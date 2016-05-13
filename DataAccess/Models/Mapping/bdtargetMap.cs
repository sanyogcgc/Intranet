using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class bdtargetMap : EntityTypeConfiguration<bdtarget>
    {
        public bdtargetMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("bdtarget");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.bdid).HasColumnName("bdid");
            this.Property(t => t.targetreceipt).HasColumnName("targetreceipt");
            this.Property(t => t.targetmonth).HasColumnName("targetmonth");
            this.Property(t => t.targetyear).HasColumnName("targetyear");
        }
    }
}
