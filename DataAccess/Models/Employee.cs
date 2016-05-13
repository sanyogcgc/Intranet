using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public partial class Employee
    {
        public int Emp_id { get; set; }

        public string Fname { get; set; }

        public string Mname { get; set; }

        public string Lname { get; set; }

        public string Fathername { get; set; }

        public string EmpCode { get; set; }

        public string emailid { get; set; }

        public string Status { get; set; }

        public string UserName { get; set; }

        public string Pwd { get; set; }

        public Nullable<int> Unit { get; set; }

        public Nullable<int> Designation_id { get; set; }

        public Nullable<System.DateTime> StartDate { get; set; }

        public Nullable<System.DateTime> dob { get; set; }

        public Nullable<System.DateTime> dtOfRsgn { get; set; }

        public Nullable<int> supervisor { get; set; }

        public string jobType { get; set; }

        public string shift { get; set; }

        public Nullable<int> Leave_Reporting_Authority { get; set; }

        public string Bank_Account_No { get; set; }

        public Nullable<int> Extnno { get; set; }

        public string PANno { get; set; }

        public string Passportno { get; set; }

        public string Maritalstatus { get; set; }

        public string Gender { get; set; }

        public string Anniversary { get; set; }

        public string spouse { get; set; }

        public string picture { get; set; }

        public string experience { get; set; }

        public string qualification { get; set; }

        public string Companies { get; set; }

        public string Responsibility { get; set; }

        public string strengths { get; set; }

        public string hobbies { get; set; }

        public string career { get; set; }

        public string CAaddress { get; set; }

        public string CAcity { get; set; }

        public string CAstate { get; set; }

        public string CApin { get; set; }

        public Nullable<int> CAcountry { get; set; }

        public string PAaddress { get; set; }

        public string PAcity { get; set; }

        public string PAstate { get; set; }

        public string PApin { get; set; }

        public Nullable<int> PAcountry { get; set; }

        public string Mobile { get; set; }

        public string homephone { get; set; }

        public string pemail { get; set; }

        public string msnid { get; set; }

        public string yahooid { get; set; }

        public string skypeid { get; set; }

        public string emername { get; set; }

        public string emerrelation { get; set; }

        public string emeraddress { get; set; }

        public string emermobile { get; set; }

        public string emertel { get; set; }

        public string joinsal { get; set; }

        public string cursal { get; set; }

        public string source { get; set; }

        public string sourcename { get; set; }

        public string rcost { get; set; }

        public string ramount { get; set; }

        public string salacno { get; set; }

        public string bankbr { get; set; }

        public Nullable<System.DateTime> dtcontract { get; set; }

        public string notice { get; set; }

        public string emprating { get; set; }

        public Nullable<System.DateTime> dtupdate { get; set; }

        public string reason { get; set; }

        public string DisciplinaryAction { get; set; }

        public string AppraisalDue { get; set; }

        public string AppraisalRecord { get; set; }

        public string Comments { get; set; }

        public Nullable<System.DateTime> ProbationPeriod { get; set; }

        public Nullable<System.DateTime> ExitDate { get; set; }

        public int? Technology_ID { get; set; }
    }
}