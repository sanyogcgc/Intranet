using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TDMap : EntityTypeConfiguration<TD>
    {
        public TDMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedTime)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("TDS");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Category_Code).HasColumnName("Category_Code");
            this.Property(t => t.SubCategory_Code).HasColumnName("SubCategory_Code");
            this.Property(t => t.RevnId).HasColumnName("RevnId");
            this.Property(t => t.Project_Code).HasColumnName("Project_Code");
            this.Property(t => t.Employee_Code).HasColumnName("Employee_Code");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Amount_Spent).HasColumnName("Amount_Spent");
            this.Property(t => t.Date_Paid).HasColumnName("Date_Paid");
            this.Property(t => t.Transaction_Type).HasColumnName("Transaction_Type");
            this.Property(t => t.Currency_Code).HasColumnName("Currency_Code");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Current_Exchange_Rate).HasColumnName("Current_Exchange_Rate");
            this.Property(t => t.Vendor).HasColumnName("Vendor");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.TotalInr).HasColumnName("TotalInr");
            this.Property(t => t.TotalDollar).HasColumnName("TotalDollar");
        }
    }
}
