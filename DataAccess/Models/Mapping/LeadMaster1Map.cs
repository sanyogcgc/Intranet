using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LeadMaster1Map : EntityTypeConfiguration<LeadMaster1>
    {
        public LeadMaster1Map()
        {
            // Primary Key
            this.HasKey(t => t.LeadId);

            // Properties
            this.Property(t => t.Firstname)
                .HasMaxLength(100);

            this.Property(t => t.Lastname)
                .HasMaxLength(100);

            this.Property(t => t.Company)
                .HasMaxLength(500);

            this.Property(t => t.Title)
                .HasMaxLength(200);

            this.Property(t => t.Address1)
                .HasMaxLength(8000);

            this.Property(t => t.Address2)
                .HasMaxLength(8000);

            this.Property(t => t.City)
                .HasMaxLength(500);

            this.Property(t => t.State)
                .HasMaxLength(200);

            this.Property(t => t.Zip)
                .HasMaxLength(20);

            this.Property(t => t.Country)
                .HasMaxLength(100);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(500);

            this.Property(t => t.Website)
                .HasMaxLength(200);

            this.Property(t => t.ListOfServices)
                .HasMaxLength(8000);

            this.Property(t => t.ProjectScope)
                .HasMaxLength(8000);

            this.Property(t => t.Currency)
                .HasMaxLength(50);

            this.Property(t => t.DateSubmit)
                .HasMaxLength(50);

            this.Property(t => t.TimeSubmit)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(200);

            this.Property(t => t.ReasonDead)
                .HasMaxLength(200);

            this.Property(t => t.Subject)
                .HasMaxLength(8000);

            this.Property(t => t.Message)
                .HasMaxLength(8000);

            this.Property(t => t.WhatInformation)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("LeadMaster1");
            this.Property(t => t.LeadId).HasColumnName("LeadId");
            this.Property(t => t.Assigned).HasColumnName("Assigned");
            this.Property(t => t.Archived).HasColumnName("Archived");
            this.Property(t => t.LeadSource).HasColumnName("LeadSource");
            this.Property(t => t.Firstname).HasColumnName("Firstname");
            this.Property(t => t.Lastname).HasColumnName("Lastname");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.ListOfServices).HasColumnName("ListOfServices");
            this.Property(t => t.ProjectScope).HasColumnName("ProjectScope");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.DateSubmit).HasColumnName("DateSubmit");
            this.Property(t => t.TimeSubmit).HasColumnName("TimeSubmit");
            this.Property(t => t.DateArchive).HasColumnName("DateArchive");
            this.Property(t => t.DateUnarchive).HasColumnName("DateUnarchive");
            this.Property(t => t.RequestDateTime).HasColumnName("RequestDateTime");
            this.Property(t => t.RequestActive).HasColumnName("RequestActive");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.BDID).HasColumnName("BDID");
            this.Property(t => t.ReasonDead).HasColumnName("ReasonDead");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.WhatInformation).HasColumnName("WhatInformation");
            this.Property(t => t.Comments).HasColumnName("Comments");
        }
    }
}
