using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class IssueMap : EntityTypeConfiguration<Issue>
    {
        public IssueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.issue_id, t.priority_id, t.status_id });

            // Properties
            this.Property(t => t.issue_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.issue_name)
                .HasMaxLength(100);

            this.Property(t => t.priority_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.version)
                .HasMaxLength(50);

            this.Property(t => t.project_code)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Client_See)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Altname)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Issues");
            this.Property(t => t.issue_id).HasColumnName("issue_id");
            this.Property(t => t.issue_name).HasColumnName("issue_name");
            this.Property(t => t.issue_desc).HasColumnName("issue_desc");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.priority_id).HasColumnName("priority_id");
            this.Property(t => t.status_id).HasColumnName("status_id");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.assigned_to).HasColumnName("assigned_to");
            this.Property(t => t.assigned_to_orig).HasColumnName("assigned_to_orig");
            this.Property(t => t.date_submitted).HasColumnName("date_submitted");
            this.Property(t => t.date_resolved).HasColumnName("date_resolved");
            this.Property(t => t.date_modified).HasColumnName("date_modified");
            this.Property(t => t.modified_by).HasColumnName("modified_by");
            this.Property(t => t.project_code).HasColumnName("project_code");
            this.Property(t => t.due_date).HasColumnName("due_date");
            this.Property(t => t.hours_allocated).HasColumnName("hours_allocated");
            this.Property(t => t.category_id).HasColumnName("category_id");
            this.Property(t => t.type_id).HasColumnName("type_id");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.Client_See).HasColumnName("Client_See");
            this.Property(t => t.Altname).HasColumnName("Altname");
        }
    }
}
