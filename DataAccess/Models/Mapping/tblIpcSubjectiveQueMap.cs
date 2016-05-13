using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblIpcSubjectiveQueMap : EntityTypeConfiguration<tblIpcSubjectiveQue>
    {
        public tblIpcSubjectiveQueMap()
        {
            // Primary Key
            this.HasKey(t => t.SubQues_id);

            // Properties
            this.Property(t => t.Subques)
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("tblIpcSubjectiveQues");
            this.Property(t => t.SubQues_id).HasColumnName("SubQues_id");
            this.Property(t => t.Subques).HasColumnName("Subques");
            this.Property(t => t.catid).HasColumnName("catid");
        }
    }
}
