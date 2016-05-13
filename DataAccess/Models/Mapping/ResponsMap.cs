using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ResponsMap : EntityTypeConfiguration<Respons>
    {
        public ResponsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Response_Id, t.status_id });

            // Properties
            this.Property(t => t.Response_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.status_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Altname)
                .HasMaxLength(100);

            this.Property(t => t.version)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Responses");
            this.Property(t => t.Response_Id).HasColumnName("Response_Id");
            this.Property(t => t.Issue_Id).HasColumnName("Issue_Id");
            this.Property(t => t.Response).HasColumnName("Response");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.type_id).HasColumnName("type_id");
            this.Property(t => t.priority_id).HasColumnName("priority_id");
            this.Property(t => t.status_id).HasColumnName("status_id");
            this.Property(t => t.Assigned_to).HasColumnName("Assigned_to");
            this.Property(t => t.date_response).HasColumnName("date_response");
            this.Property(t => t.Hours_Spent).HasColumnName("Hours_Spent");
            this.Property(t => t.Hours_Allocated).HasColumnName("Hours_Allocated");
            this.Property(t => t.Altname).HasColumnName("Altname");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.due_date).HasColumnName("due_date");
        }
    }
}
