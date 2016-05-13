using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class Risks_For_RDBMap : EntityTypeConfiguration<Risks_For_RDB>
    {
        public Risks_For_RDBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Risk_Id, t.TypeId, t.Show });

            // Properties
            this.Property(t => t.Risk_Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitId)
                .HasMaxLength(50);

            this.Property(t => t.Measure)
                .HasMaxLength(50);

            this.Property(t => t.R)
                .HasMaxLength(50);

            this.Property(t => t.A)
                .HasMaxLength(50);

            this.Property(t => t.C)
                .HasMaxLength(50);

            this.Property(t => t.I)
                .HasMaxLength(100);

            this.Property(t => t.Risk_Desc)
                .HasMaxLength(5000);

            this.Property(t => t.Expected_Impact)
                .HasMaxLength(50);

            this.Property(t => t.Mitigation_Plan)
                .HasMaxLength(5000);

            this.Property(t => t.Backup_Plan)
                .HasMaxLength(5000);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.AssociateProject)
                .HasMaxLength(50);

            this.Property(t => t.TypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitName)
                .HasMaxLength(50);

            this.Property(t => t.SourceName)
                .HasMaxLength(50);

            this.Property(t => t.LikelihoodName)
                .HasMaxLength(50);

            this.Property(t => t.ImpactName)
                .HasMaxLength(50);

            this.Property(t => t.TypeName)
                .HasMaxLength(50);

            this.Property(t => t.CategoryName)
                .HasMaxLength(50);

            this.Property(t => t.SubCategoryName)
                .HasMaxLength(50);

            this.Property(t => t.EmpName)
                .HasMaxLength(100);

            this.Property(t => t.ActionTaken_Comments)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Risks_For_RDB");
            this.Property(t => t.Risk_Id).HasColumnName("Risk_Id");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.Identification_Date).HasColumnName("Identification_Date");
            this.Property(t => t.LikelihoodId).HasColumnName("LikelihoodId");
            this.Property(t => t.ImpactId).HasColumnName("ImpactId");
            this.Property(t => t.Measure).HasColumnName("Measure");
            this.Property(t => t.R).HasColumnName("R");
            this.Property(t => t.A).HasColumnName("A");
            this.Property(t => t.C).HasColumnName("C");
            this.Property(t => t.I).HasColumnName("I");
            this.Property(t => t.Risk_Desc).HasColumnName("Risk_Desc");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.Expected_Impact).HasColumnName("Expected_Impact");
            this.Property(t => t.Mitigation_Plan).HasColumnName("Mitigation_Plan");
            this.Property(t => t.Backup_Plan).HasColumnName("Backup_Plan");
            this.Property(t => t.Due_Date).HasColumnName("Due_Date");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Closure_Date).HasColumnName("Closure_Date");
            this.Property(t => t.SubCategoryId).HasColumnName("SubCategoryId");
            this.Property(t => t.AssociateProject).HasColumnName("AssociateProject");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.SourceName).HasColumnName("SourceName");
            this.Property(t => t.LikelihoodName).HasColumnName("LikelihoodName");
            this.Property(t => t.ImpactName).HasColumnName("ImpactName");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.SubCategoryName).HasColumnName("SubCategoryName");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.Show).HasColumnName("Show");
            this.Property(t => t.EmpName).HasColumnName("EmpName");
            this.Property(t => t.ResolvedDate).HasColumnName("ResolvedDate");
            this.Property(t => t.AssocProjId).HasColumnName("AssocProjId");
            this.Property(t => t.ResponsibleId).HasColumnName("ResponsibleId");
            this.Property(t => t.AccountableId).HasColumnName("AccountableId");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.ActionTaken_Comments).HasColumnName("ActionTaken_Comments");
        }
    }
}
