using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class UserlogMap : EntityTypeConfiguration<Userlog>
    {
        public UserlogMap()
        {
            // Primary Key
            this.HasKey(t => t.Descpid);

            // Properties
            this.Property(t => t.Categoryid)
                .HasMaxLength(50);

            this.Property(t => t.Processareaid)
                .HasMaxLength(50);

            this.Property(t => t.Assignedtoid)
                .HasMaxLength(50);

            this.Property(t => t.Descp)
                .HasMaxLength(8000);

            this.Property(t => t.Groupid)
                .HasMaxLength(50);

            this.Property(t => t.Acknowledgementid)
                .HasMaxLength(50);

            this.Property(t => t.ResolutionStatement)
                .HasMaxLength(8000);

            this.Property(t => t.AcceptanceComments)
                .HasMaxLength(2000);

            this.Property(t => t.Title)
                .HasMaxLength(150);

            this.Property(t => t.ResComment)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Userlog");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.Categoryid).HasColumnName("Categoryid");
            this.Property(t => t.Processareaid).HasColumnName("Processareaid");
            this.Property(t => t.Assignedtoid).HasColumnName("Assignedtoid");
            this.Property(t => t.Assigneddate).HasColumnName("Assigneddate");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.Descp).HasColumnName("Descp");
            this.Property(t => t.Descpid).HasColumnName("Descpid");
            this.Property(t => t.ExpectedClosureDate).HasColumnName("ExpectedClosureDate");
            this.Property(t => t.Groupid).HasColumnName("Groupid");
            this.Property(t => t.grpCategoryid).HasColumnName("grpCategoryid");
            this.Property(t => t.Acknowledgementid).HasColumnName("Acknowledgementid");
            this.Property(t => t.ActualClosureDate).HasColumnName("ActualClosureDate");
            this.Property(t => t.Acceptanceid).HasColumnName("Acceptanceid");
            this.Property(t => t.ResolutionStatement).HasColumnName("ResolutionStatement");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.ExpectedClosureDate2).HasColumnName("ExpectedClosureDate2");
            this.Property(t => t.ExpectedClosureDate3).HasColumnName("ExpectedClosureDate3");
            this.Property(t => t.ActualClosureDate3).HasColumnName("ActualClosureDate3");
            this.Property(t => t.ActualClosureDate2).HasColumnName("ActualClosureDate2");
            this.Property(t => t.datecounter).HasColumnName("datecounter");
            this.Property(t => t.AcceptanceComments).HasColumnName("AcceptanceComments");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ResComment).HasColumnName("ResComment");
            this.Property(t => t.EMailSend).HasColumnName("EMailSend");
        }
    }
}
