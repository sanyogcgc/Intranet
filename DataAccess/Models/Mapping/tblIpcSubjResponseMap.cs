using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblIpcSubjResponseMap : EntityTypeConfiguration<tblIpcSubjResponse>
    {
        public tblIpcSubjResponseMap()
        {
            // Primary Key
            this.HasKey(t => t.subjResponse_Id);

            // Properties
            this.Property(t => t.Remarks)
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("tblIpcSubjResponse");
            this.Property(t => t.subjResponse_Id).HasColumnName("subjResponse_Id");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.currentyear).HasColumnName("currentyear");
            this.Property(t => t.ques_Id).HasColumnName("ques_Id");
        }
    }
}
