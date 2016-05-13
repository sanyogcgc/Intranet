using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Emp_id);

            // Properties
            this.Property(t => t.Fname)
                .HasMaxLength(50);

            this.Property(t => t.Mname)
                .HasMaxLength(50);

            this.Property(t => t.Lname)
                .HasMaxLength(50);

            this.Property(t => t.Fathername)
                .HasMaxLength(50);

            this.Property(t => t.EmpCode)
                .HasMaxLength(50);

            this.Property(t => t.emailid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.Pwd)
                .HasMaxLength(50);

            this.Property(t => t.jobType)
                .HasMaxLength(30);

            this.Property(t => t.shift)
                .HasMaxLength(30);

            this.Property(t => t.Bank_Account_No)
                .HasMaxLength(50);

            this.Property(t => t.PANno)
                .HasMaxLength(50);

            this.Property(t => t.Passportno)
                .HasMaxLength(50);

            this.Property(t => t.Maritalstatus)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .HasMaxLength(50);

            this.Property(t => t.Anniversary)
                .HasMaxLength(50);

            this.Property(t => t.spouse)
                .HasMaxLength(50);

            this.Property(t => t.picture)
                .HasMaxLength(500);

            this.Property(t => t.experience)
                .HasMaxLength(50);

            this.Property(t => t.qualification)
                .HasMaxLength(1000);

            this.Property(t => t.Companies)
                .HasMaxLength(1000);

            this.Property(t => t.Responsibility)
                .HasMaxLength(1000);

            this.Property(t => t.strengths)
                .HasMaxLength(1000);

            this.Property(t => t.hobbies)
                .HasMaxLength(1000);

            this.Property(t => t.career)
                .HasMaxLength(1000);

            this.Property(t => t.CAaddress)
                .HasMaxLength(500);

            this.Property(t => t.CAcity)
                .HasMaxLength(50);

            this.Property(t => t.CAstate)
                .HasMaxLength(50);

            this.Property(t => t.CApin)
                .HasMaxLength(50);

            this.Property(t => t.PAaddress)
                .HasMaxLength(500);

            this.Property(t => t.PAcity)
                .HasMaxLength(50);

            this.Property(t => t.PAstate)
                .HasMaxLength(50);

            this.Property(t => t.PApin)
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .HasMaxLength(50);

            this.Property(t => t.homephone)
                .HasMaxLength(50);

            this.Property(t => t.pemail)
                .HasMaxLength(50);

            this.Property(t => t.msnid)
                .HasMaxLength(50);

            this.Property(t => t.yahooid)
                .HasMaxLength(50);

            this.Property(t => t.skypeid)
                .HasMaxLength(50);

            this.Property(t => t.emername)
                .HasMaxLength(50);

            this.Property(t => t.emerrelation)
                .HasMaxLength(50);

            this.Property(t => t.emeraddress)
                .HasMaxLength(50);

            this.Property(t => t.emermobile)
                .HasMaxLength(50);

            this.Property(t => t.emertel)
                .HasMaxLength(50);

            this.Property(t => t.joinsal)
                .HasMaxLength(50);

            this.Property(t => t.cursal)
                .HasMaxLength(50);

            this.Property(t => t.source)
                .HasMaxLength(50);

            this.Property(t => t.sourcename)
                .HasMaxLength(50);

            this.Property(t => t.rcost)
                .HasMaxLength(50);

            this.Property(t => t.ramount)
                .HasMaxLength(50);

            this.Property(t => t.salacno)
                .HasMaxLength(50);

            this.Property(t => t.bankbr)
                .HasMaxLength(50);

            this.Property(t => t.notice)
                .HasMaxLength(50);

            this.Property(t => t.emprating)
                .HasMaxLength(50);

            this.Property(t => t.reason)
                .HasMaxLength(50);

            this.Property(t => t.DisciplinaryAction)
                .HasMaxLength(50);

            this.Property(t => t.AppraisalDue)
                .HasMaxLength(50);

            this.Property(t => t.AppraisalRecord)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(8000);



            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.Emp_id).HasColumnName("Emp_id");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Mname).HasColumnName("Mname");
            this.Property(t => t.Lname).HasColumnName("Lname");
            this.Property(t => t.Fathername).HasColumnName("Fathername");
            this.Property(t => t.EmpCode).HasColumnName("EmpCode");
            this.Property(t => t.emailid).HasColumnName("emailid");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Pwd).HasColumnName("Pwd");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Designation_id).HasColumnName("Designation_id");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.dob).HasColumnName("dob");
            this.Property(t => t.dtOfRsgn).HasColumnName("dtOfRsgn");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.jobType).HasColumnName("jobType");
            this.Property(t => t.shift).HasColumnName("shift");
            this.Property(t => t.Leave_Reporting_Authority).HasColumnName("Leave_Reporting_Authority");
            this.Property(t => t.Bank_Account_No).HasColumnName("Bank_Account_No");
            this.Property(t => t.Extnno).HasColumnName("Extnno");
            this.Property(t => t.PANno).HasColumnName("PANno");
            this.Property(t => t.Passportno).HasColumnName("Passportno");
            this.Property(t => t.Maritalstatus).HasColumnName("Maritalstatus");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Anniversary).HasColumnName("Anniversary");
            this.Property(t => t.spouse).HasColumnName("spouse");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.experience).HasColumnName("experience");
            this.Property(t => t.qualification).HasColumnName("qualification");
            this.Property(t => t.Companies).HasColumnName("Companies");
            this.Property(t => t.Responsibility).HasColumnName("Responsibility");
            this.Property(t => t.strengths).HasColumnName("strengths");
            this.Property(t => t.hobbies).HasColumnName("hobbies");
            this.Property(t => t.career).HasColumnName("career");
            this.Property(t => t.CAaddress).HasColumnName("CAaddress");
            this.Property(t => t.CAcity).HasColumnName("CAcity");
            this.Property(t => t.CAstate).HasColumnName("CAstate");
            this.Property(t => t.CApin).HasColumnName("CApin");
            this.Property(t => t.CAcountry).HasColumnName("CAcountry");
            this.Property(t => t.PAaddress).HasColumnName("PAaddress");
            this.Property(t => t.PAcity).HasColumnName("PAcity");
            this.Property(t => t.PAstate).HasColumnName("PAstate");
            this.Property(t => t.PApin).HasColumnName("PApin");
            this.Property(t => t.PAcountry).HasColumnName("PAcountry");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.homephone).HasColumnName("homephone");
            this.Property(t => t.pemail).HasColumnName("pemail");
            this.Property(t => t.msnid).HasColumnName("msnid");
            this.Property(t => t.yahooid).HasColumnName("yahooid");
            this.Property(t => t.skypeid).HasColumnName("skypeid");
            this.Property(t => t.emername).HasColumnName("emername");
            this.Property(t => t.emerrelation).HasColumnName("emerrelation");
            this.Property(t => t.emeraddress).HasColumnName("emeraddress");
            this.Property(t => t.emermobile).HasColumnName("emermobile");
            this.Property(t => t.emertel).HasColumnName("emertel");
            this.Property(t => t.joinsal).HasColumnName("joinsal");
            this.Property(t => t.cursal).HasColumnName("cursal");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.sourcename).HasColumnName("sourcename");
            this.Property(t => t.rcost).HasColumnName("rcost");
            this.Property(t => t.ramount).HasColumnName("ramount");
            this.Property(t => t.salacno).HasColumnName("salacno");
            this.Property(t => t.bankbr).HasColumnName("bankbr");
            this.Property(t => t.dtcontract).HasColumnName("dtcontract");
            this.Property(t => t.notice).HasColumnName("notice");
            this.Property(t => t.emprating).HasColumnName("emprating");
            this.Property(t => t.dtupdate).HasColumnName("dtupdate");
            this.Property(t => t.reason).HasColumnName("reason");
            this.Property(t => t.DisciplinaryAction).HasColumnName("DisciplinaryAction");
            this.Property(t => t.AppraisalDue).HasColumnName("AppraisalDue");
            this.Property(t => t.AppraisalRecord).HasColumnName("AppraisalRecord");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.ProbationPeriod).HasColumnName("ProbationPeriod");
            this.Property(t => t.ExitDate).HasColumnName("ExitDate");
            this.Property(t => t.Technology_ID).HasColumnName("Technology_ID");
        }
    }
}
