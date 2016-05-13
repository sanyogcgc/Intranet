using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Tools_ManualMap : EntityTypeConfiguration<Tools_Manual>
    {
        public Tools_ManualMap()
        {
            // Primary Key
            this.HasKey(t => t.ToolsId);

            // Properties
            this.Property(t => t.ToolsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ManualPath)
                .HasMaxLength(500);

            this.Property(t => t.Remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Tools_Manual");
            this.Property(t => t.ToolsId).HasColumnName("ToolsId");
            this.Property(t => t.ManualPath).HasColumnName("ManualPath");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
        }
    }
}
