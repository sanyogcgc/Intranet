using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class TrgTestMap : EntityTypeConfiguration<TrgTest>
    {
        public TrgTestMap()
        {
            // Primary Key
            this.HasKey(t => t.TrgTestID);

            // Properties
            this.Property(t => t.TrgTestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestName)
                .HasMaxLength(100);

            this.Property(t => t.TrgTstDescription)
                .HasMaxLength(100);

            this.Property(t => t.MinMarks)
                .HasMaxLength(10);

            this.Property(t => t.PostorPre)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("TrgTests");
            this.Property(t => t.TrgTestID).HasColumnName("TrgTestID");
            this.Property(t => t.TrgID).HasColumnName("TrgID");
            this.Property(t => t.TestName).HasColumnName("TestName");
            this.Property(t => t.TrgTstDescription).HasColumnName("TrgTstDescription");
            this.Property(t => t.MinMarks).HasColumnName("MinMarks");
            this.Property(t => t.PostorPre).HasColumnName("PostorPre");
        }
    }
}
