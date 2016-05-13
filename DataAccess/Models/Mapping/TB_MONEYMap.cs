using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TB_MONEYMap : EntityTypeConfiguration<TB_MONEY>
    {
        public TB_MONEYMap()
        {
            // Primary Key
            this.HasKey(t => t.moneyid);

            // Properties
            this.Property(t => t.REASON)
                .HasMaxLength(500);

            this.Property(t => t.Department)
                .HasMaxLength(50);

            this.Property(t => t.month)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_MONEY");
            this.Property(t => t.moneyid).HasColumnName("moneyid");
            this.Property(t => t.EMPID).HasColumnName("EMPID");
            this.Property(t => t.MONEY).HasColumnName("MONEY");
            this.Property(t => t.REASON).HasColumnName("REASON");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.DonateEMPID).HasColumnName("DonateEMPID");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.month).HasColumnName("month");
        }
    }
}
