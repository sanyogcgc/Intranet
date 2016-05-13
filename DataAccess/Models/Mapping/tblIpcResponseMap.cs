using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblIpcResponseMap : EntityTypeConfiguration<tblIpcResponse>
    {
        public tblIpcResponseMap()
        {
            // Primary Key
            this.HasKey(t => t.Response_Id);

            // Properties
            this.Property(t => t.Remarks)
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("tblIpcResponse");
            this.Property(t => t.Response_Id).HasColumnName("Response_Id");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Ratingid).HasColumnName("Ratingid");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.currentyear).HasColumnName("currentyear");
            this.Property(t => t.ques_Id).HasColumnName("ques_Id");
        }
    }
}
