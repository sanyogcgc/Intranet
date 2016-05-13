using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class RevenueMap : EntityTypeConfiguration<Revenue>
    {
        public RevenueMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedTime)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Revenues");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Project_Code).HasColumnName("Project_Code");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Amount_Received).HasColumnName("Amount_Received");
            this.Property(t => t.Date_Received).HasColumnName("Date_Received");
            this.Property(t => t.Transaction).HasColumnName("Transaction");
            this.Property(t => t.Currency_Code).HasColumnName("Currency_Code");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Current_Exchange_Rate).HasColumnName("Current_Exchange_Rate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.TotalInr).HasColumnName("TotalInr");
            this.Property(t => t.TotalDollar).HasColumnName("TotalDollar");
        }
    }
}
