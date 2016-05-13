using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Client_Name)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .HasMaxLength(100);

            this.Property(t => t.FirstName)
                .HasMaxLength(200);

            this.Property(t => t.LastName)
                .HasMaxLength(200);

            this.Property(t => t.emailid)
                .HasMaxLength(200);

            this.Property(t => t.ClientCode)
                .HasMaxLength(50);

            this.Property(t => t.ClientC)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Client");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Client_Name).HasColumnName("Client_Name");
            this.Property(t => t.Lead_Source).HasColumnName("Lead_Source");
            this.Property(t => t.City_Code).HasColumnName("City_Code");
            this.Property(t => t.Directory).HasColumnName("Directory");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.emailid).HasColumnName("emailid");
            this.Property(t => t.ClientCode).HasColumnName("ClientCode");
            this.Property(t => t.ClientC).HasColumnName("ClientC");
        }
    }
}
