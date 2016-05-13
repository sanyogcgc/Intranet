using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Userlog
    {
        public int Userid { get; set; }
        public Nullable<int> Typeid { get; set; }
        public string Categoryid { get; set; }
        public string Processareaid { get; set; }
        public string Assignedtoid { get; set; }
        public Nullable<System.DateTime> Assigneddate { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public string Descp { get; set; }
        public int Descpid { get; set; }
        public Nullable<System.DateTime> ExpectedClosureDate { get; set; }
        public string Groupid { get; set; }
        public Nullable<int> grpCategoryid { get; set; }
        public string Acknowledgementid { get; set; }
        public Nullable<System.DateTime> ActualClosureDate { get; set; }
        public Nullable<int> Acceptanceid { get; set; }
        public string ResolutionStatement { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<System.DateTime> ExpectedClosureDate2 { get; set; }
        public Nullable<System.DateTime> ExpectedClosureDate3 { get; set; }
        public Nullable<System.DateTime> ActualClosureDate3 { get; set; }
        public Nullable<System.DateTime> ActualClosureDate2 { get; set; }
        public Nullable<int> datecounter { get; set; }
        public string AcceptanceComments { get; set; }
        public string Title { get; set; }
        public string ResComment { get; set; }
        public Nullable<bool> EMailSend { get; set; }
    }
}
