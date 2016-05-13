using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tb_prainitiativesMap : EntityTypeConfiguration<tb_prainitiatives>
    {
        public tb_prainitiativesMap()
        {
            // Primary Key
            this.HasKey(t => t.InitiativeID);

            // Properties
            this.Property(t => t.Initiatives)
                .HasMaxLength(1150);

            this.Property(t => t.status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tb_prainitiatives");
            this.Property(t => t.InitiativeID).HasColumnName("InitiativeID");
            this.Property(t => t.empid).HasColumnName("empid");
            this.Property(t => t.Initiatives).HasColumnName("Initiatives");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.RMREMARKS).HasColumnName("RMREMARKS");
        }
    }
}
