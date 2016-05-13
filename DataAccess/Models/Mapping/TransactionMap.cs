using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TransactionMap : EntityTypeConfiguration<Transaction>
    {
        public TransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Transactions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date_Sent).HasColumnName("Date_Sent");
            this.Property(t => t.Date_Received).HasColumnName("Date_Received");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.USBank).HasColumnName("USBank");
            this.Property(t => t.IndiaBank).HasColumnName("IndiaBank");
            this.Property(t => t.EEFC).HasColumnName("EEFC");
            this.Property(t => t.Cash).HasColumnName("Cash");
            this.Property(t => t.Transferring_AC).HasColumnName("Transferring_AC");
            this.Property(t => t.Total_Amt).HasColumnName("Total_Amt");
            this.Property(t => t.Currency_Exchange_Rate).HasColumnName("Currency_Exchange_Rate");
            this.Property(t => t.Transaction_Type).HasColumnName("Transaction_Type");
            this.Property(t => t.Comments).HasColumnName("Comments");
        }
    }
}
