using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Mapping
{
    internal class ResourceUtilizationMap : EntityTypeConfiguration<ResourceUtilization>
    {
        public ResourceUtilizationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            //Properties
            //this.Property(t => t.Emp_Id);
            this.Property(t => t.CurrentBillable);
            this.Property(t => t.CurrentNonBillable);
            this.Property(t => t.NextBillable);
            this.Property(t => t.NextNonBillable);
            this.Property(t => t.InvoiceHours);
            this.Property(t => t.ProjectId);

            // Table & Column Mappings
            this.ToTable("ResourceUtilization");
            this.Property(t => t.ID).HasColumnName("ID");
            //this.Property(t => t.Emp_Id).HasColumnName("Emp_Id");
            this.Property(t => t.CurrentBillable).HasColumnName("CurrentBillable");
            this.Property(t => t.CurrentNonBillable).HasColumnName("CurrentNonBillable");
            this.Property(t => t.NextBillable).HasColumnName("NextBillable");
            this.Property(t => t.NextNonBillable).HasColumnName("NextNonBillable");
            this.Property(t => t.InvoiceHours).HasColumnName("InvoiceHours");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
        }
    }
}