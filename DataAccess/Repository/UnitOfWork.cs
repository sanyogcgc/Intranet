using DataAccess.Models;
using DataAccess.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;

namespace DataAccess.Repository
{
    /// <summary>
    /// Class UnitOfWork.
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region Constructor(s)/Properties

        /// <summary>
        /// The database context
        /// </summary>
        private readonly ISHIRINTRANETContext dbContext;

        /// <summary>
        /// The _transaction
        /// </summary>
        private DbContextTransaction _transaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        public UnitOfWork()
        {
            // Force intialization of Sql Providers Service in order to get the required dll intialized.
            SqlProviderServices _ = SqlProviderServices.Instance;
            dbContext = new ISHIRINTRANETContext();
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        public ISHIRINTRANETContext DbContext
        {
            get { return dbContext; }
        }

        #endregion Constructor(s)/Properties

        #region Generic Repository Instance

        /// <summary>
        /// The p arcadr repository
        /// </summary>
        private GenericRepository<Employee> employeeRepository;
        private GenericRepository<Holiday> holidayRepository;
        private GenericRepository<Project> projectRepository;
        private GenericRepository<ProjMember> projMemberRepository;
        private GenericRepository<Designation> designationRepository;
        private GenericRepository<ResourceUtilization> resourceUtilizationRepository;
        private GenericRepository<WorkLog1> workLogRepository;
        private GenericRepository<WorkLog1> workLog1Repository;
        private GenericRepository<Invoice> invoiceRepository;
        private GenericRepository<Phase> phaseRepository;
        private GenericRepository<ProjTask> projTaskRepository;
        private GenericRepository<unit> unitRepository;
        private GenericRepository<ProjectTime> projectTimeRepository;
        private GenericRepository<ProjModule> projModuleRepository;
        private GenericRepository<ProjTaskMaping> projTaskMapingRepository;
        private GenericRepository<TechnologyGroup> technologyGroupRepository;
        private GenericRepository<ResourceConfiguration> resourceConfigurationRepository;
        
        #endregion Generic Repository Instance

        #region Repository Instance

        /// <summary>
        /// Gets the Employee repository.
        /// </summary>
        /// <value>
        /// The Employee repository.
        /// </value>
        public GenericRepository<Employee> EmployeeRepository
        {
            get { return employeeRepository ?? (employeeRepository = new GenericRepository<Employee>(dbContext)); }
        }

        /// <summary>
        ///
        /// </summary>


        public GenericRepository<Project> ProjectRepository
        {
            get { return projectRepository ?? (projectRepository = new GenericRepository<Project>(dbContext)); }
        }

        private GenericRepository<Client> clientRepository;

        public GenericRepository<Client> ClientRepository
        {
            get { return clientRepository ?? (clientRepository = new GenericRepository<Client>(dbContext)); }
        }


        public GenericRepository<ProjMember> ProjMemberRepository
        {
            get { return projMemberRepository ?? (projMemberRepository = new GenericRepository<ProjMember>(dbContext)); }
        }


        public GenericRepository<Designation> DesignationRepository
        {
            get { return designationRepository ?? (designationRepository = new GenericRepository<Designation>(dbContext)); }
        }

        public GenericRepository<ResourceUtilization> ResourceUtilizationRepository
        {
            get { return resourceUtilizationRepository ?? (resourceUtilizationRepository = new GenericRepository<ResourceUtilization>(dbContext)); }
        }

        public GenericRepository<Holiday> HolidayRepository
        {
            get { return holidayRepository ?? (holidayRepository = new GenericRepository<Holiday>(dbContext)); }
        }

        public GenericRepository<WorkLog1> WorkLogRepository
        {
            get { return workLogRepository ?? (workLogRepository = new GenericRepository<WorkLog1>(dbContext)); }
        }

        public GenericRepository<WorkLog1> WorkLog1Repository
        {
            get { return workLog1Repository ?? (workLog1Repository = new GenericRepository<WorkLog1>(dbContext)); }
        }

        public GenericRepository<Invoice> InvoiceRepository
        {
            get { return invoiceRepository ?? (invoiceRepository = new GenericRepository<Invoice>(dbContext)); }
        }

        public GenericRepository<Phase> PhaseRepository
        {
            get { return phaseRepository ?? (phaseRepository = new GenericRepository<Phase>(dbContext)); }
        }

        public GenericRepository<ProjTask> ProjTaskRepository
        {
            get { return projTaskRepository ?? (projTaskRepository = new GenericRepository<ProjTask>(dbContext)); }
        }

        public GenericRepository<unit> UnitRepository
        {
            get { return unitRepository ?? (unitRepository = new GenericRepository<unit>(dbContext)); }
        }

        public GenericRepository<ProjectTime> ProjectTimeRepository
        {
            get { return projectTimeRepository ?? (projectTimeRepository = new GenericRepository<ProjectTime>(dbContext)); }
        }

        public GenericRepository<ProjModule> ProjModuleRepository
        {
            get { return projModuleRepository ?? (projModuleRepository = new GenericRepository<ProjModule>(dbContext)); }
        }

        public GenericRepository<ProjTaskMaping> ProjTaskMapingRepository
        {
            get { return projTaskMapingRepository ?? (projTaskMapingRepository = new GenericRepository<ProjTaskMaping>(dbContext)); }
        }

        public GenericRepository<TechnologyGroup> TechnologyGroupRepository
        {
            get { return technologyGroupRepository ?? (technologyGroupRepository = new GenericRepository<TechnologyGroup>(dbContext)); }
        }
        public GenericRepository<ResourceConfiguration> ResourceConfigurationRepository
        {
            get { return resourceConfigurationRepository ?? (resourceConfigurationRepository = new GenericRepository<ResourceConfiguration>(dbContext)); }
        }

        
        #endregion Repository Instance

        #region Public Functions/Properties

        /// <summary>
        /// Starts the transaction.
        /// </summary>
        public void StartTransaction()
        {
            _transaction = dbContext.Database.BeginTransaction();
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            try
            {
                dbContext.SaveChanges();
                _transaction.Commit();
            }
            catch (Exception ex)
            {
                _transaction.Rollback();
                throw ex;
            }
        }

        /// <summary>
        /// Rollbacks this instance.
        /// </summary>
        public void Rollback()
        {
            try
            {
                _transaction.Rollback();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Manages the entity validation.
        /// </summary>
        /// <param name="validationRequired">if set to <c>true</c> [validation required].</param>
        public void ManageEntityValidation(bool validationRequired)
        {
            dbContext.Configuration.ValidateOnSaveEnabled = validationRequired;
        }

        /// <summary>
        /// Executes the read query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        public IEnumerable<T> ExecuteReadQuery<T>(string query) where T : BaseEntity
        {
            return dbContext.Database.SqlQuery<T>(query).ToList();
        }

        /// <summary>
        /// Executes the scalar read query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>
        /// System.Int32.
        /// </returns>
        public int ExecuteScalarReadQuery(string query)
        {
            return dbContext.Database.SqlQuery<int>(query).FirstOrDefault();
        }

        #endregion Public Functions/Properties

        #region Dispose

        /// <summary>
        /// The disposed
        /// </summary>
        private bool disposed;

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public void Dispose()
        {
            if (_transaction != null)
            {
                //Commit();
            }

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            disposed = true;
        }

        #endregion Dispose
    }
}