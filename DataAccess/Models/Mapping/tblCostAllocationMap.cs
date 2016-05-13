using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblCostAllocationMap : EntityTypeConfiguration<tblCostAllocation>
    {
        public tblCostAllocationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PIN, t.costallocationid });

            // Properties
            this.Property(t => t.PIN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.currency)
                .HasMaxLength(50);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.costallocationid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("tblCostAllocation");
            this.Property(t => t.PIN).HasColumnName("PIN");
            this.Property(t => t.ExpenseAmount).HasColumnName("ExpenseAmount");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.currency).HasColumnName("currency");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.costallocationid).HasColumnName("costallocationid");
        }
    }
}
