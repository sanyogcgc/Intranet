using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class PRARatingMap : EntityTypeConfiguration<PRARating>
    {
        public PRARatingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PRA_Id, t.Emp_id, t.MonthId, t.CreateDate, t.Quarter, t.Awards });

            // Properties
            this.Property(t => t.PRA_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Emp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MonthId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quarter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Awards)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PRARating");
            this.Property(t => t.PRA_Id).HasColumnName("PRA_Id");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.MonthId).HasColumnName("MonthId");
            this.Property(t => t.April).HasColumnName("April");
            this.Property(t => t.May).HasColumnName("May");
            this.Property(t => t.June).HasColumnName("June");
            this.Property(t => t.July).HasColumnName("July");
            this.Property(t => t.August).HasColumnName("August");
            this.Property(t => t.September).HasColumnName("September");
            this.Property(t => t.October).HasColumnName("October");
            this.Property(t => t.November).HasColumnName("November");
            this.Property(t => t.December).HasColumnName("December");
            this.Property(t => t.January).HasColumnName("January");
            this.Property(t => t.February).HasColumnName("February");
            this.Property(t => t.March).HasColumnName("March");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.Quarter).HasColumnName("Quarter");
            this.Property(t => t.Awards).HasColumnName("Awards");
        }
    }
}
