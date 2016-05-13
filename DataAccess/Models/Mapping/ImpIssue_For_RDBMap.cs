using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ImpIssue_For_RDBMap : EntityTypeConfiguration<ImpIssue_For_RDB>
    {
        public ImpIssue_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ImpIssue_For_RDB");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
