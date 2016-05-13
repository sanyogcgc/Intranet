using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblIpcQueMap : EntityTypeConfiguration<tblIpcQue>
    {
        public tblIpcQueMap()
        {
            // Primary Key
            this.HasKey(t => t.Ques_Id);

            // Properties
            this.Property(t => t.Ques)
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("tblIpcQues");
            this.Property(t => t.Ques_Id).HasColumnName("Ques_Id");
            this.Property(t => t.Ques).HasColumnName("Ques");
            this.Property(t => t.SubCat_Id).HasColumnName("SubCat_Id");
        }
    }
}
