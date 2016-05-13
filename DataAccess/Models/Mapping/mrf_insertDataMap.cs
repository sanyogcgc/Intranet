using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class mrf_insertDataMap : EntityTypeConfiguration<mrf_insertData>
    {
        public mrf_insertDataMap()
        {
            // Primary Key
            this.HasKey(t => t.MRFID);

            // Properties
            this.Property(t => t.priority)
                .HasMaxLength(50);

            this.Property(t => t.department)
                .HasMaxLength(50);

            this.Property(t => t.HWtype)
                .HasMaxLength(500);

            this.Property(t => t.HWDetails)
                .HasMaxLength(750);

            this.Property(t => t.type)
                .HasMaxLength(50);

            this.Property(t => t.usgaeTimeFrame)
                .HasMaxLength(750);

            this.Property(t => t.comments)
                .HasMaxLength(1150);

            this.Property(t => t.status)
                .HasMaxLength(50);

            this.Property(t => t.ExpCloseTime)
                .HasMaxLength(50);

            this.Property(t => t.systemcomments)
                .HasMaxLength(1150);

            this.Property(t => t.RmComments)
                .HasMaxLength(1150);

            // Table & Column Mappings
            this.ToTable("mrf_insertData");
            this.Property(t => t.MRFID).HasColumnName("MRFID");
            this.Property(t => t.EMPID).HasColumnName("EMPID");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.department).HasColumnName("department");
            this.Property(t => t.HWtype).HasColumnName("HWtype");
            this.Property(t => t.HWDetails).HasColumnName("HWDetails");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.usgaeTimeFrame).HasColumnName("usgaeTimeFrame");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.submitDate).HasColumnName("submitDate");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.ExpCloseTime).HasColumnName("ExpCloseTime");
            this.Property(t => t.systemcomments).HasColumnName("systemcomments");
            this.Property(t => t.RmComments).HasColumnName("RmComments");
        }
    }
}
