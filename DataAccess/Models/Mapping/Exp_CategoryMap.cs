using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Exp_CategoryMap : EntityTypeConfiguration<Exp_Category>
    {
        public Exp_CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Expense_Category)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Exp_Category");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Expense_Category).HasColumnName("Expense_Category");
        }
    }
}
