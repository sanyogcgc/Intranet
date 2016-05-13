using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class UNIT_SPECIFICMap : EntityTypeConfiguration<UNIT_SPECIFIC>
    {
        public UNIT_SPECIFICMap()
        {
            // Primary Key
            this.HasKey(t => t.RHallotted);

            // Properties
            this.Property(t => t.unit_name)
                .HasMaxLength(50);

            this.Property(t => t.empname)
                .HasMaxLength(50);

            this.Property(t => t.designation_name)
                .HasMaxLength(50);

            this.Property(t => t.spreason)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UNIT_SPECIFIC");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.unit_name).HasColumnName("unit_name");
            this.Property(t => t.empname).HasColumnName("empname");
            this.Property(t => t.designation_name).HasColumnName("designation_name");
            this.Property(t => t.Doj).HasColumnName("Doj");
            this.Property(t => t.CLallowed).HasColumnName("CLallowed");
            this.Property(t => t.CLallotted).HasColumnName("CLallotted");
            this.Property(t => t.SLallowed).HasColumnName("SLallowed");
            this.Property(t => t.SLallotted).HasColumnName("SLallotted");
            this.Property(t => t.PLallowed).HasColumnName("PLallowed");
            this.Property(t => t.PLallotted).HasColumnName("PLallotted");
            this.Property(t => t.ALallowed).HasColumnName("ALallowed");
            this.Property(t => t.ALallotted).HasColumnName("ALallotted");
            this.Property(t => t.RHallowed).HasColumnName("RHallowed");
            this.Property(t => t.RHallotted).HasColumnName("RHallotted");
            this.Property(t => t.workonsunday).HasColumnName("workonsunday");
            this.Property(t => t.splLleaves).HasColumnName("splLleaves");
            this.Property(t => t.spreason).HasColumnName("spreason");
            this.Property(t => t.pending).HasColumnName("pending");
            this.Property(t => t.saldeduction).HasColumnName("saldeduction");
            this.Property(t => t.fromdate).HasColumnName("fromdate");
            this.Property(t => t.todate).HasColumnName("todate");
        }
    }
}
