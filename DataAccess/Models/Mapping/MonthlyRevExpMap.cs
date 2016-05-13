using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class MonthlyRevExpMap : EntityTypeConfiguration<MonthlyRevExp>
    {
        public MonthlyRevExpMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("MonthlyRevExp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ExpYear).HasColumnName("ExpYear");
            this.Property(t => t.ExpMonth).HasColumnName("ExpMonth");
            this.Property(t => t.USBase).HasColumnName("USBase");
            this.Property(t => t.Expanses).HasColumnName("Expanses");
            this.Property(t => t.INRBase).HasColumnName("INRBase");
            this.Property(t => t.Revenue).HasColumnName("Revenue");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
        }
    }
}
