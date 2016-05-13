using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class VIEW5Map : EntityTypeConfiguration<VIEW5>
    {
        public VIEW5Map()
        {
            // Primary Key
            this.HasKey(t => t.Business_Developer);

            // Properties
            this.Property(t => t.Business_Developer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.am)
                .HasMaxLength(50);

            this.Property(t => t.spoc)
                .HasMaxLength(50);

            this.Property(t => t.bd)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VIEW5");
            this.Property(t => t.Business_Developer).HasColumnName("Business_Developer");
            this.Property(t => t.intAccountManager).HasColumnName("intAccountManager");
            this.Property(t => t.am).HasColumnName("am");
            this.Property(t => t.spoc).HasColumnName("spoc");
            this.Property(t => t.bd).HasColumnName("bd");
        }
    }
}
