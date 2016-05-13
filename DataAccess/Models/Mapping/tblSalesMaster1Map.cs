using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class tblSalesMaster1Map : EntityTypeConfiguration<tblSalesMaster1>
    {
        public tblSalesMaster1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.IDS, t.Project_ID });

            // Properties
            this.Property(t => t.PIN)
                .HasMaxLength(50);

            this.Property(t => t.ClientId)
                .HasMaxLength(50);

            this.Property(t => t.ProjectName)
                .HasMaxLength(100);

            this.Property(t => t.LeadSource_O_N)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Payment)
                .HasMaxLength(50);

            this.Property(t => t.ExchangeRate)
                .HasMaxLength(50);

            this.Property(t => t.totalINR)
                .HasMaxLength(50);

            this.Property(t => t.ProposeEfforts)
                .HasMaxLength(50);

            this.Property(t => t.TotalDollar)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.IDS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Project_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Phase)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblSalesMaster1");
            this.Property(t => t.PIN).HasColumnName("PIN");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.SignUpDate).HasColumnName("SignUpDate");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.BDId).HasColumnName("BDId");
            this.Property(t => t.LeadSource_O_N).HasColumnName("LeadSource_O_N");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.UpdationDate).HasColumnName("UpdationDate");
            this.Property(t => t.Geography).HasColumnName("Geography");
            this.Property(t => t.unit).HasColumnName("unit");
            this.Property(t => t.TL).HasColumnName("TL");
            this.Property(t => t.Payment).HasColumnName("Payment");
            this.Property(t => t.ClientCode).HasColumnName("ClientCode");
            this.Property(t => t.ExchangeRate).HasColumnName("ExchangeRate");
            this.Property(t => t.totalINR).HasColumnName("totalINR");
            this.Property(t => t.ProposeEfforts).HasColumnName("ProposeEfforts");
            this.Property(t => t.TotalDollar).HasColumnName("TotalDollar");
            this.Property(t => t.IDS).HasColumnName("IDS");
            this.Property(t => t.Project_ID).HasColumnName("Project_ID");
            this.Property(t => t.ProjStatus).HasColumnName("ProjStatus");
            this.Property(t => t.Phase).HasColumnName("Phase");
        }
    }
}
