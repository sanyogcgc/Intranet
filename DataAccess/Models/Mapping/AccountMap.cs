using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Account_Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Accounts");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Account_Name).HasColumnName("Account_Name");
            this.Property(t => t.Amount).HasColumnName("Amount");
        }
    }
}
