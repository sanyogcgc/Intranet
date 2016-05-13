using DataAccess.DAL;
using DataAccess.Models;
using DataAccess.Models.Mapping;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public partial class ISHIRINTRANETContext : DbContext
    {
        static ISHIRINTRANETContext()
        {
            Database.SetInitializer<ISHIRINTRANETContext>(null);
        }

        public ISHIRINTRANETContext()
            : base("Name=ISHIRINTRANETContext")
        {
        }

        public DbSet<ResourceUtilization> ResourceUtilizations { get; set; }

        public DbSet<Acceptance> Acceptances { get; set; }

        public DbSet<AccessRight> AccessRights { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<ADEmployee> ADEmployees { get; set; }

        public DbSet<AttendanceApproval> AttendanceApprovals { get; set; }

        public DbSet<AttendanceAppStatu> AttendanceAppStatus { get; set; }

        public DbSet<b> b { get; set; }

        public DbSet<bdtarget> bdtargets { get; set; }

        public DbSet<bktracking> bktrackings { get; set; }

        public DbSet<book> books { get; set; }

        public DbSet<BooksIssueReceive> BooksIssueReceives { get; set; }

        public DbSet<BooksIssueReceiveNw> BooksIssueReceiveNws { get; set; }

        public DbSet<BooksNw> BooksNws { get; set; }

        public DbSet<BussDev> BussDevs { get; set; }

        public DbSet<Cat_SubCat_For_RDB> Cat_SubCat_For_RDB { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<category1> categories1 { get; set; }

        public DbSet<Category_For_RDB> Category_For_RDB { get; set; }

        public DbSet<CauseMaster> CauseMasters { get; set; }

        public DbSet<cd> cds { get; set; }

        public DbSet<cdtracking> cdtrackings { get; set; }

        public DbSet<cfReport> cfReports { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<CommTrck> CommTrcks { get; set; }

        public DbSet<Communication> Communications { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<directory_category> directory_category { get; set; }

        public DbSet<directory_country> directory_country { get; set; }

        public DbSet<directory_subcategory> directory_subcategory { get; set; }

        public DbSet<dtproperty> dtproperties { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }

        public DbSet<EmployeeLeaveStatu> EmployeeLeaveStatus { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Event_Detail> Event_Detail { get; set; }

        public DbSet<Exp_Category> Exp_Category { get; set; }

        public DbSet<Exp_Sub_Category> Exp_Sub_Category { get; set; }

        public DbSet<Expens> Expenses { get; set; }

        public DbSet<FeedbackManagment> FeedbackManagments { get; set; }

        public DbSet<file> files { get; set; }

        public DbSet<FinYearMaster> FinYearMasters { get; set; }

        public DbSet<GroupCategory> GroupCategories { get; set; }

        public DbSet<GroupCatStatu> GroupCatStatus { get; set; }

        public DbSet<GroupUserMapping> GroupUserMappings { get; set; }

        public DbSet<Holiday> Holidays { get; set; }

        public DbSet<Idea> Ideas { get; set; }

        public DbSet<ILink> ILinks { get; set; }

        public DbSet<Impact_For_RDB> Impact_For_RDB { get; set; }

        public DbSet<ImpIssue_For_RDB> ImpIssue_For_RDB { get; set; }

        public DbSet<InterestArea> InterestAreas { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<IParentLink> IParentLinks { get; set; }

        public DbSet<IshirGroup> IshirGroups { get; set; }

        public DbSet<ishirnew> ishirnews { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<LeadMaster> LeadMasters { get; set; }

        public DbSet<LeadMaster1> LeadMaster1 { get; set; }

        public DbSet<Leadsource> Leadsources { get; set; }

        public DbSet<LeaveCategory> LeaveCategories { get; set; }

        public DbSet<LeaveCLSLTable> LeaveCLSLTables { get; set; }

        public DbSet<LeaveEmployeeStatusRecord> LeaveEmployeeStatusRecords { get; set; }

        public DbSet<LeaveGrant> LeaveGrants { get; set; }

        public DbSet<LeaveReportingGroup> LeaveReportingGroups { get; set; }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }

        public DbSet<Leaverequesttransaction> Leaverequesttransactions { get; set; }

        public DbSet<LeaveStatusMaster> LeaveStatusMasters { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<Likelihood_For_RDB> Likelihood_For_RDB { get; set; }

        public DbSet<MailSetting> MailSettings { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<MonthlyRevExp> MonthlyRevExps { get; set; }

        public DbSet<MonthMaster> MonthMasters { get; set; }

        public DbSet<mrf_insertData> mrf_insertData { get; set; }

        public DbSet<NCAttachement> NCAttachements { get; set; }

        public DbSet<NCDetail> NCDetails { get; set; }

        public DbSet<NCDetailsHistory> NCDetailsHistories { get; set; }

        public DbSet<NCMaster> NCMasters { get; set; }

        public DbSet<NCProcess> NCProcesses { get; set; }

        public DbSet<NCSType> NCSTypes { get; set; }

        public DbSet<NCTrendAnalysi> NCTrendAnalysis { get; set; }

        public DbSet<PatOnTheBackAward> PatOnTheBackAwards { get; set; }

        public DbSet<PaymentReceipt> PaymentReceipts { get; set; }

        public DbSet<PaymentType> PaymentTypes { get; set; }

        public DbSet<PeriodMaster> PeriodMasters { get; set; }

        public DbSet<PFReport> PFReports { get; set; }

        public DbSet<Phase> Phases { get; set; }

        public DbSet<PRARating> PRARatings { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<prjsubtype> prjsubtypes { get; set; }

        public DbSet<PrjType> PrjTypes { get; set; }

        public DbSet<ProjActivity> ProjActivities { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectTime> ProjectTimes { get; set; }

        public DbSet<ProjectType> ProjectTypes { get; set; }

        public DbSet<ProjLead> ProjLeads { get; set; }

        public DbSet<ProjMember> ProjMembers { get; set; }

        public DbSet<ProjMilestone> ProjMilestones { get; set; }

        public DbSet<ProjModule> ProjModules { get; set; }

        public DbSet<ProjTask> ProjTasks { get; set; }

        public DbSet<ProjTaskMaping> ProjTaskMapings { get; set; }

        public DbSet<Proposal> Proposals { get; set; }

        public DbSet<ReasonDead> ReasonDeads { get; set; }

        public DbSet<ReceiptUnit> ReceiptUnits { get; set; }

        public DbSet<ReceptionANDLibrary> ReceptionANDLibraries { get; set; }

        public DbSet<Respons> Responses { get; set; }

        public DbSet<Revenue> Revenues { get; set; }

        public DbSet<Risks_For_RDB> Risks_For_RDB { get; set; }

        public DbSet<RockStarForBUH> RockStarForBUHs { get; set; }

        public DbSet<RockStarForHRG> RockStarForHRGs { get; set; }

        public DbSet<RockStarForRM> RockStarForRMs { get; set; }

        public DbSet<Salary> Salaries { get; set; }

        public DbSet<SAM_Group> SAM_Group { get; set; }

        public DbSet<SAM_Role> SAM_Role { get; set; }

        public DbSet<sampEmp> sampEmps { get; set; }

        public DbSet<sampTarUser> sampTarUsers { get; set; }

        public DbSet<SChildLink> SChildLinks { get; set; }

        public DbSet<Security> Securities { get; set; }

        public DbSet<setting> settings { get; set; }

        public DbSet<SGroup> SGroups { get; set; }

        public DbSet<SkillCategory> SkillCategories { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SkillSubCategory> SkillSubCategories { get; set; }

        public DbSet<Source_For_RDB> Source_For_RDB { get; set; }

        public DbSet<SParent_Links> SParent_Links { get; set; }

        public DbSet<SRole> SRoles { get; set; }

        public DbSet<Status_For_RDB> Status_For_RDB { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<StatusMaster> StatusMasters { get; set; }

        public DbSet<SubCat_For_RDB> SubCat_For_RDB { get; set; }

        public DbSet<SubUnit> SubUnits { get; set; }

        public DbSet<support_insertTable> support_insertTable { get; set; }

        public DbSet<targetunit> targetunits { get; set; }

        public DbSet<TarType> TarTypes { get; set; }

        public DbSet<taruser> tarusers { get; set; }

        public DbSet<Tax> Taxes { get; set; }

        public DbSet<TB_MONEY> TB_MONEY { get; set; }

        public DbSet<tb_pra> tb_pra { get; set; }

        public DbSet<tb_prafeedback> tb_prafeedback { get; set; }

        public DbSet<tb_prainitiatives> tb_prainitiatives { get; set; }

        public DbSet<tb_praStatus> tb_praStatus { get; set; }

        public DbSet<tb_trainee_feedback> tb_trainee_feedback { get; set; }

        public DbSet<tb_trainer_feedback> tb_trainer_feedback { get; set; }

        public DbSet<tbl_Resoure_Non_Defaulter> tbl_Resoure_Non_Defaulter { get; set; }

        public DbSet<tbl_SystemDown> tbl_SystemDown { get; set; }

        public DbSet<tblAPMaster> tblAPMasters { get; set; }

        public DbSet<tblbcmaster> tblbcmasters { get; set; }

        public DbSet<tblBDMaster> tblBDMasters { get; set; }

        public DbSet<tblCatagory> tblCatagories { get; set; }

        public DbSet<tblClientMaster1> tblClientMaster1 { get; set; }

        public DbSet<tblCostAllocation> tblCostAllocations { get; set; }

        public DbSet<tblcostsmaster> tblcostsmasters { get; set; }

        public DbSet<tblCurrencyExchange> tblCurrencyExchanges { get; set; }

        public DbSet<tblCurrencyMaster> tblCurrencyMasters { get; set; }

        public DbSet<tblGeographyMaster> tblGeographyMasters { get; set; }

        public DbSet<tblIpcCat> tblIpcCats { get; set; }

        public DbSet<tblIpcQue> tblIpcQues { get; set; }

        public DbSet<tblIpcRating> tblIpcRatings { get; set; }

        public DbSet<tblIpcResponse> tblIpcResponses { get; set; }

        public DbSet<tblIpcSubcat> tblIpcSubcats { get; set; }

        public DbSet<tblIpcSubjectiveQue> tblIpcSubjectiveQues { get; set; }

        public DbSet<tblIpcSubjResponse> tblIpcSubjResponses { get; set; }

        public DbSet<tblLeadSourceMaster> tblLeadSourceMasters { get; set; }

        public DbSet<TblMilestoneService> TblMilestoneServices { get; set; }

        public DbSet<tblMonthMaster> tblMonthMasters { get; set; }

        public DbSet<tblPaymentMaster> tblPaymentMasters { get; set; }

        public DbSet<tblProjectDurationDetail> tblProjectDurationDetails { get; set; }

        public DbSet<tblProjectMilestoneDetails1> tblProjectMilestoneDetails1 { get; set; }

        public DbSet<tblSalesMaster1> tblSalesMaster1 { get; set; }

        public DbSet<tblSalesTeamMaster> tblSalesTeamMasters { get; set; }

        public DbSet<tblSalesTeamMember> tblSalesTeamMembers { get; set; }

        public DbSet<tblServicesMaster> tblServicesMasters { get; set; }

        public DbSet<tblStatusMaster> tblStatusMasters { get; set; }

        public DbSet<tblTraining> tblTrainings { get; set; }

        public DbSet<tbltypemaster> tbltypemasters { get; set; }

        public DbSet<TD> TDS { get; set; }

        public DbSet<TempEmployee> TempEmployees { get; set; }

        public DbSet<temptimelog> temptimelogs { get; set; }

        public DbSet<timelog> timelogs { get; set; }

        public DbSet<timespentlog> timespentlogs { get; set; }

        public DbSet<tmpRequestMaster> tmpRequestMasters { get; set; }

        public DbSet<Tools_Manual> Tools_Manual { get; set; }

        public DbSet<Trainee> Trainees { get; set; }

        public DbSet<traing_linkTable> traing_linkTable { get; set; }

        public DbSet<trainingcalenderForm> trainingcalenderForms { get; set; }

        public DbSet<trainingrequest> trainingrequests { get; set; }

        public DbSet<TransactionMaster> TransactionMasters { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TrgCategory> TrgCategories { get; set; }

        public DbSet<TrgEligibility> TrgEligibilities { get; set; }

        public DbSet<TrgParticipant> TrgParticipants { get; set; }

        public DbSet<TrgRegistration> TrgRegistrations { get; set; }

        public DbSet<TrgSchedule> TrgSchedules { get; set; }

        public DbSet<TrgTest> TrgTests { get; set; }

        public DbSet<TrgTrainer> TrgTrainers { get; set; }

        public DbSet<TrgTraining> TrgTrainings { get; set; }

        public DbSet<TrgVenue> TrgVenues { get; set; }

        public DbSet<unit> units { get; set; }

        public DbSet<UNIT_SPECIFIC> UNIT_SPECIFIC { get; set; }

        public DbSet<unitimage> unitimages { get; set; }

        public DbSet<UnitMaster> UnitMasters { get; set; }

        public DbSet<Userlog> Userlogs { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<worklog> worklogs { get; set; }

        public DbSet<WorkLog1> WorkLog1 { get; set; }

        public DbSet<TechnologyGroup> TechnologyGroup { get; set; }

        public DbSet<empunit> empunits { get; set; }

        public DbSet<Monthly_WorkLogData> Monthly_WorkLogData { get; set; }

        public DbSet<Monthly_WorkLogData_Projectwise> Monthly_WorkLogData_Projectwise { get; set; }

        public DbSet<test> tests { get; set; }

        public DbSet<v1> v1 { get; set; }

        public DbSet<vCommTrckDet> vCommTrckDets { get; set; }

        public DbSet<vCurrentDateTime> vCurrentDateTimes { get; set; }

        public DbSet<VIEW1> VIEW1 { get; set; }

        public DbSet<VIEW1s> VIEW1s { get; set; }

        public DbSet<VIEW5> VIEW5 { get; set; }

        public DbSet<VIEW7> VIEW7 { get; set; }

        public DbSet<ViewProject> ViewProjects { get; set; }

        public DbSet<vPrjTime> vPrjTimes { get; set; }

        public DbSet<vw_LostBooks> vw_LostBooks { get; set; }

        public DbSet<vw_LostBooksAll> vw_LostBooksAll { get; set; }

        public DbSet<vw_ModulewisePlannedEfforts> vw_ModulewisePlannedEfforts { get; set; }

        public DbSet<vw_ModulewiseVariance> vw_ModulewiseVariance { get; set; }

        public DbSet<vw_Project_Audit_NC> vw_Project_Audit_NC { get; set; }

        public DbSet<vw_QuarterlyAudit> vw_QuarterlyAudit { get; set; }

        public DbSet<vw_VariancePhasewise> vw_VariancePhasewise { get; set; }

        public DbSet<vw_WorkLogDefaulter> vw_WorkLogDefaulter { get; set; }

        public DbSet<VwAllIssuedBook> VwAllIssuedBooks { get; set; }

        public DbSet<VwAllMissedBook> VwAllMissedBooks { get; set; }

        public DbSet<ResourceConfiguration> ResourceConfiguration { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ResourceUtilizationMap());
            modelBuilder.Configurations.Add(new AcceptanceMap());
            modelBuilder.Configurations.Add(new AccessRightMap());
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new ADEmployeeMap());
            modelBuilder.Configurations.Add(new AttendanceApprovalMap());
            modelBuilder.Configurations.Add(new AttendanceAppStatuMap());
            modelBuilder.Configurations.Add(new bMap());
            modelBuilder.Configurations.Add(new bdtargetMap());
            modelBuilder.Configurations.Add(new bktrackingMap());
            modelBuilder.Configurations.Add(new bookMap());
            modelBuilder.Configurations.Add(new BooksIssueReceiveMap());
            modelBuilder.Configurations.Add(new BooksIssueReceiveNwMap());
            modelBuilder.Configurations.Add(new BooksNwMap());
            modelBuilder.Configurations.Add(new BussDevMap());
            modelBuilder.Configurations.Add(new Cat_SubCat_For_RDBMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new category1Map());
            modelBuilder.Configurations.Add(new Category_For_RDBMap());
            modelBuilder.Configurations.Add(new CauseMasterMap());
            modelBuilder.Configurations.Add(new cdMap());
            modelBuilder.Configurations.Add(new cdtrackingMap());
            modelBuilder.Configurations.Add(new cfReportMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new CommTrckMap());
            modelBuilder.Configurations.Add(new CommunicationMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new DesignationMap());
            modelBuilder.Configurations.Add(new directory_categoryMap());
            modelBuilder.Configurations.Add(new directory_countryMap());
            modelBuilder.Configurations.Add(new directory_subcategoryMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeLeaveMap());
            modelBuilder.Configurations.Add(new EmployeeLeaveStatuMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new Event_DetailMap());
            modelBuilder.Configurations.Add(new Exp_CategoryMap());
            modelBuilder.Configurations.Add(new Exp_Sub_CategoryMap());
            modelBuilder.Configurations.Add(new ExpensMap());
            modelBuilder.Configurations.Add(new FeedbackManagmentMap());
            modelBuilder.Configurations.Add(new fileMap());
            modelBuilder.Configurations.Add(new FinYearMasterMap());
            modelBuilder.Configurations.Add(new GroupCategoryMap());
            modelBuilder.Configurations.Add(new GroupCatStatuMap());
            modelBuilder.Configurations.Add(new GroupUserMappingMap());
            modelBuilder.Configurations.Add(new ResourceConfigurationMap());
            modelBuilder.Configurations.Add(new HolidayMap());
            modelBuilder.Configurations.Add(new IdeaMap());
            modelBuilder.Configurations.Add(new ILinkMap());
            modelBuilder.Configurations.Add(new Impact_For_RDBMap());
            modelBuilder.Configurations.Add(new ImpIssue_For_RDBMap());
            modelBuilder.Configurations.Add(new InterestAreaMap());
            modelBuilder.Configurations.Add(new IParentLinkMap());
            modelBuilder.Configurations.Add(new IshirGroupMap());
            modelBuilder.Configurations.Add(new ishirnewMap());
            modelBuilder.Configurations.Add(new IssueMap());
            modelBuilder.Configurations.Add(new LeadMasterMap());
            modelBuilder.Configurations.Add(new LeadMaster1Map());
            modelBuilder.Configurations.Add(new LeadsourceMap());
            modelBuilder.Configurations.Add(new LeaveCategoryMap());
            modelBuilder.Configurations.Add(new LeaveCLSLTableMap());
            modelBuilder.Configurations.Add(new LeaveEmployeeStatusRecordMap());
            modelBuilder.Configurations.Add(new LeaveGrantMap());
            modelBuilder.Configurations.Add(new LeaveReportingGroupMap());
            modelBuilder.Configurations.Add(new LeaveRequestMap());
            modelBuilder.Configurations.Add(new LeaverequesttransactionMap());
            modelBuilder.Configurations.Add(new LeaveStatusMasterMap());
            modelBuilder.Configurations.Add(new LeaveTypeMap());
            modelBuilder.Configurations.Add(new Likelihood_For_RDBMap());
            modelBuilder.Configurations.Add(new MailSettingMap());
            modelBuilder.Configurations.Add(new ModuleMap());
            modelBuilder.Configurations.Add(new MonthlyRevExpMap());
            modelBuilder.Configurations.Add(new MonthMasterMap());
            modelBuilder.Configurations.Add(new mrf_insertDataMap());
            modelBuilder.Configurations.Add(new NCAttachementMap());
            modelBuilder.Configurations.Add(new NCDetailMap());
            modelBuilder.Configurations.Add(new NCDetailsHistoryMap());
            modelBuilder.Configurations.Add(new NCMasterMap());
            modelBuilder.Configurations.Add(new NCProcessMap());
            modelBuilder.Configurations.Add(new NCSTypeMap());
            modelBuilder.Configurations.Add(new NCTrendAnalysiMap());
            modelBuilder.Configurations.Add(new PatOnTheBackAwardMap());
            modelBuilder.Configurations.Add(new PaymentReceiptMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new PeriodMasterMap());
            modelBuilder.Configurations.Add(new PFReportMap());
            modelBuilder.Configurations.Add(new PhaseMap());
            modelBuilder.Configurations.Add(new PRARatingMap());
            modelBuilder.Configurations.Add(new PriorityMap());
            modelBuilder.Configurations.Add(new prjsubtypeMap());
            modelBuilder.Configurations.Add(new PrjTypeMap());
            modelBuilder.Configurations.Add(new ProjActivityMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new ProjectTimeMap());
            modelBuilder.Configurations.Add(new ProjectTypeMap());
            modelBuilder.Configurations.Add(new ProjLeadMap());
            modelBuilder.Configurations.Add(new ProjMemberMap());
            modelBuilder.Configurations.Add(new ProjMilestoneMap());
            modelBuilder.Configurations.Add(new ProjModuleMap());
            modelBuilder.Configurations.Add(new ProjTaskMap());
            modelBuilder.Configurations.Add(new ProjTaskMapingMap());
            modelBuilder.Configurations.Add(new ProposalMap());
            modelBuilder.Configurations.Add(new ReasonDeadMap());
            modelBuilder.Configurations.Add(new ReceiptUnitMap());
            modelBuilder.Configurations.Add(new ReceptionANDLibraryMap());
            modelBuilder.Configurations.Add(new ResponsMap());
            modelBuilder.Configurations.Add(new RevenueMap());
            modelBuilder.Configurations.Add(new Risks_For_RDBMap());
            modelBuilder.Configurations.Add(new RockStarForBUHMap());
            modelBuilder.Configurations.Add(new RockStarForHRGMap());
            modelBuilder.Configurations.Add(new RockStarForRMMap());
            modelBuilder.Configurations.Add(new SalaryMap());
            modelBuilder.Configurations.Add(new SAM_GroupMap());
            modelBuilder.Configurations.Add(new SAM_RoleMap());
            modelBuilder.Configurations.Add(new sampEmpMap());
            modelBuilder.Configurations.Add(new sampTarUserMap());
            modelBuilder.Configurations.Add(new SChildLinkMap());
            modelBuilder.Configurations.Add(new SecurityMap());
            modelBuilder.Configurations.Add(new settingMap());
            modelBuilder.Configurations.Add(new SGroupMap());
            modelBuilder.Configurations.Add(new SkillCategoryMap());
            modelBuilder.Configurations.Add(new SkillMap());
            modelBuilder.Configurations.Add(new SkillSubCategoryMap());
            modelBuilder.Configurations.Add(new Source_For_RDBMap());
            modelBuilder.Configurations.Add(new SParent_LinksMap());
            modelBuilder.Configurations.Add(new SRoleMap());
            modelBuilder.Configurations.Add(new Status_For_RDBMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new StatusMasterMap());
            modelBuilder.Configurations.Add(new SubCat_For_RDBMap());
            modelBuilder.Configurations.Add(new SubUnitMap());
            modelBuilder.Configurations.Add(new support_insertTableMap());
            modelBuilder.Configurations.Add(new targetunitMap());
            modelBuilder.Configurations.Add(new TarTypeMap());
            modelBuilder.Configurations.Add(new taruserMap());
            modelBuilder.Configurations.Add(new TaxMap());
            modelBuilder.Configurations.Add(new TB_MONEYMap());
            modelBuilder.Configurations.Add(new tb_praMap());
            modelBuilder.Configurations.Add(new tb_prafeedbackMap());
            modelBuilder.Configurations.Add(new tb_prainitiativesMap());
            modelBuilder.Configurations.Add(new tb_praStatusMap());
            modelBuilder.Configurations.Add(new tb_trainee_feedbackMap());
            modelBuilder.Configurations.Add(new tb_trainer_feedbackMap());
            modelBuilder.Configurations.Add(new tbl_Resoure_Non_DefaulterMap());
            modelBuilder.Configurations.Add(new tbl_SystemDownMap());
            modelBuilder.Configurations.Add(new tblAPMasterMap());
            modelBuilder.Configurations.Add(new tblbcmasterMap());
            modelBuilder.Configurations.Add(new tblBDMasterMap());
            modelBuilder.Configurations.Add(new tblCatagoryMap());
            modelBuilder.Configurations.Add(new tblClientMaster1Map());
            modelBuilder.Configurations.Add(new tblCostAllocationMap());
            modelBuilder.Configurations.Add(new tblcostsmasterMap());
            modelBuilder.Configurations.Add(new tblCurrencyExchangeMap());
            modelBuilder.Configurations.Add(new tblCurrencyMasterMap());
            modelBuilder.Configurations.Add(new tblGeographyMasterMap());
            modelBuilder.Configurations.Add(new tblIpcCatMap());
            modelBuilder.Configurations.Add(new tblIpcQueMap());
            modelBuilder.Configurations.Add(new tblIpcRatingMap());
            modelBuilder.Configurations.Add(new tblIpcResponseMap());
            modelBuilder.Configurations.Add(new tblIpcSubcatMap());
            modelBuilder.Configurations.Add(new tblIpcSubjectiveQueMap());
            modelBuilder.Configurations.Add(new tblIpcSubjResponseMap());
            modelBuilder.Configurations.Add(new tblLeadSourceMasterMap());
            modelBuilder.Configurations.Add(new TblMilestoneServiceMap());
            modelBuilder.Configurations.Add(new tblMonthMasterMap());
            modelBuilder.Configurations.Add(new tblPaymentMasterMap());
            modelBuilder.Configurations.Add(new tblProjectDurationDetailMap());
            modelBuilder.Configurations.Add(new tblProjectMilestoneDetails1Map());
            modelBuilder.Configurations.Add(new tblSalesMaster1Map());
            modelBuilder.Configurations.Add(new tblSalesTeamMasterMap());
            modelBuilder.Configurations.Add(new tblSalesTeamMemberMap());
            modelBuilder.Configurations.Add(new tblServicesMasterMap());
            modelBuilder.Configurations.Add(new tblStatusMasterMap());
            modelBuilder.Configurations.Add(new tblTrainingMap());
            modelBuilder.Configurations.Add(new tbltypemasterMap());
            modelBuilder.Configurations.Add(new TDMap());
            modelBuilder.Configurations.Add(new TempEmployeeMap());
            modelBuilder.Configurations.Add(new temptimelogMap());
            modelBuilder.Configurations.Add(new timelogMap());
            modelBuilder.Configurations.Add(new timespentlogMap());
            modelBuilder.Configurations.Add(new tmpRequestMasterMap());
            modelBuilder.Configurations.Add(new Tools_ManualMap());
            modelBuilder.Configurations.Add(new TraineeMap());
            modelBuilder.Configurations.Add(new traing_linkTableMap());
            modelBuilder.Configurations.Add(new trainingcalenderFormMap());
            modelBuilder.Configurations.Add(new trainingrequestMap());
            modelBuilder.Configurations.Add(new TransactionMasterMap());
            modelBuilder.Configurations.Add(new TransactionMap());
            modelBuilder.Configurations.Add(new TrgCategoryMap());
            modelBuilder.Configurations.Add(new TrgEligibilityMap());
            modelBuilder.Configurations.Add(new TrgParticipantMap());
            modelBuilder.Configurations.Add(new TrgRegistrationMap());
            modelBuilder.Configurations.Add(new TrgScheduleMap());
            modelBuilder.Configurations.Add(new TrgTestMap());
            modelBuilder.Configurations.Add(new TrgTrainerMap());
            modelBuilder.Configurations.Add(new TrgTrainingMap());
            modelBuilder.Configurations.Add(new TrgVenueMap());
            modelBuilder.Configurations.Add(new unitMap());
            modelBuilder.Configurations.Add(new UNIT_SPECIFICMap());
            modelBuilder.Configurations.Add(new unitimageMap());
            modelBuilder.Configurations.Add(new UnitMasterMap());
            modelBuilder.Configurations.Add(new UserlogMap());
            modelBuilder.Configurations.Add(new VendorMap());
            modelBuilder.Configurations.Add(new worklogMap());
            modelBuilder.Configurations.Add(new TechnologyGroupMap());
            modelBuilder.Configurations.Add(new WorkLog1Map());
            modelBuilder.Configurations.Add(new empunitMap());
            modelBuilder.Configurations.Add(new Monthly_WorkLogDataMap());
            modelBuilder.Configurations.Add(new Monthly_WorkLogData_ProjectwiseMap());
            modelBuilder.Configurations.Add(new testMap());
            modelBuilder.Configurations.Add(new v1Map());
            modelBuilder.Configurations.Add(new vCommTrckDetMap());
            modelBuilder.Configurations.Add(new vCurrentDateTimeMap());
            modelBuilder.Configurations.Add(new VIEW1Map());
            modelBuilder.Configurations.Add(new VIEW1sMap());
            modelBuilder.Configurations.Add(new VIEW5Map());
            modelBuilder.Configurations.Add(new VIEW7Map());
            modelBuilder.Configurations.Add(new ViewProjectMap());
            modelBuilder.Configurations.Add(new vPrjTimeMap());
            modelBuilder.Configurations.Add(new vw_LostBooksMap());
            modelBuilder.Configurations.Add(new vw_LostBooksAllMap());
            modelBuilder.Configurations.Add(new vw_ModulewisePlannedEffortsMap());
            modelBuilder.Configurations.Add(new vw_ModulewiseVarianceMap());
            modelBuilder.Configurations.Add(new vw_Project_Audit_NCMap());
            modelBuilder.Configurations.Add(new vw_QuarterlyAuditMap());
            modelBuilder.Configurations.Add(new vw_VariancePhasewiseMap());
            modelBuilder.Configurations.Add(new vw_WorkLogDefaulterMap());
            modelBuilder.Configurations.Add(new VwAllIssuedBookMap());
            modelBuilder.Configurations.Add(new VwAllMissedBookMap());
        }
    }
}