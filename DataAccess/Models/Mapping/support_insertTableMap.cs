using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class support_insertTableMap : EntityTypeConfiguration<support_insertTable>
    {
        public support_insertTableMap()
        {
            // Primary Key
            this.HasKey(t => t.supportid);

            // Properties
            this.Property(t => t.priority)
                .HasMaxLength(50);

            this.Property(t => t.subject)
                .IsRequired()
                .HasMaxLength(2500);

            this.Property(t => t.comments)
                .HasMaxLength(2500);

            this.Property(t => t.status)
                .HasMaxLength(50);

            this.Property(t => t.ExpCloseTime)
                .HasMaxLength(50);

            this.Property(t => t.systemcomments)
                .HasMaxLength(1150);

            this.Property(t => t.reopencomments)
                .HasMaxLength(1150);

            // Table & Column Mappings
            this.ToTable("support_insertTable");
            this.Property(t => t.supportid).HasColumnName("supportid");
            this.Property(t => t.EMPID).HasColumnName("EMPID");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.ExpCloseTime).HasColumnName("ExpCloseTime");
            this.Property(t => t.systemcomments).HasColumnName("systemcomments");
            this.Property(t => t.reopencomments).HasColumnName("reopencomments");
        }
    }
}
