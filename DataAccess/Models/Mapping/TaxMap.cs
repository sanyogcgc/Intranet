using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TaxMap : EntityTypeConfiguration<Tax>
    {
        public TaxMap()
        {
            // Primary Key
            this.HasKey(t => t.Tax_Id);

            // Properties
            this.Property(t => t.Tax_Name)
                .HasMaxLength(100);

            this.Property(t => t.Fin_Year_Id)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tax");
            this.Property(t => t.Tax_Id).HasColumnName("Tax_Id");
            this.Property(t => t.Tax_Rate).HasColumnName("Tax_Rate");
            this.Property(t => t.Tax_Name).HasColumnName("Tax_Name");
            this.Property(t => t.Fin_Year_Id).HasColumnName("Fin_Year_Id");
        }
    }
}
