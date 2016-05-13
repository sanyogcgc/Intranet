using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ResourceConfigurationMap : EntityTypeConfiguration<ResourceConfiguration>
    {
        public ResourceConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);


            // Table & Column Mappings
            this.ToTable("ResourceConfiguration");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Allocation).HasColumnName("Allocation");
            this.Property(t => t.EmpID).HasColumnName("EmpID");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
