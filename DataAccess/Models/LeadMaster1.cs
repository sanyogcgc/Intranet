using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class LeadMaster1
    {
        public int LeadId { get; set; }
        public Nullable<int> Assigned { get; set; }
        public Nullable<int> Archived { get; set; }
        public Nullable<int> LeadSource { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ListOfServices { get; set; }
        public string ProjectScope { get; set; }
        public string Currency { get; set; }
        public string DateSubmit { get; set; }
        public string TimeSubmit { get; set; }
        public Nullable<System.DateTime> DateArchive { get; set; }
        public Nullable<System.DateTime> DateUnarchive { get; set; }
        public Nullable<System.DateTime> RequestDateTime { get; set; }
        public Nullable<int> RequestActive { get; set; }
        public string Status { get; set; }
        public Nullable<int> BDID { get; set; }
        public string ReasonDead { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string WhatInformation { get; set; }
        public string Comments { get; set; }
    }
}
