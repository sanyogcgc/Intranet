using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class IdeaMap : EntityTypeConfiguration<Idea>
    {
        public IdeaMap()
        {
            // Primary Key
            this.HasKey(t => t.Idea_id);

            // Properties
            this.Property(t => t.Idea_category)
                .HasMaxLength(100);

            this.Property(t => t.Idea_Name)
                .HasMaxLength(100);

            this.Property(t => t.Details)
                .HasMaxLength(1000);

            this.Property(t => t.Doc_name)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.HR_Comments)
                .HasMaxLength(1000);

            this.Property(t => t.Eids)
                .HasMaxLength(1000);

            this.Property(t => t.Implement_Plan)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Idea");
            this.Property(t => t.Idea_id).HasColumnName("Idea_id");
            this.Property(t => t.Idea_category).HasColumnName("Idea_category");
            this.Property(t => t.Idea_Name).HasColumnName("Idea_Name");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.Doc_name).HasColumnName("Doc_name");
            this.Property(t => t.Sys_Date).HasColumnName("Sys_Date");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Posted_By).HasColumnName("Posted_By");
            this.Property(t => t.Posted_For).HasColumnName("Posted_For");
            this.Property(t => t.Parent_Id).HasColumnName("Parent_Id");
            this.Property(t => t.HR_Comments).HasColumnName("HR_Comments");
            this.Property(t => t.modify_date).HasColumnName("modify_date");
            this.Property(t => t.Y).HasColumnName("Y");
            this.Property(t => t.N).HasColumnName("N");
            this.Property(t => t.Eids).HasColumnName("Eids");
            this.Property(t => t.Implement_Plan).HasColumnName("Implement_Plan");
            this.Property(t => t.Implemented).HasColumnName("Implemented");
        }
    }
}
