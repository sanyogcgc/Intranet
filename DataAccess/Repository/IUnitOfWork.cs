using DataAccess.Models;
using DataAccess.Models.Mapping;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    /// <summary>
    /// Interface IUnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        #region Public Methods

        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();

        /// <summary>
        /// Starts the transaction.
        /// </summary>
        void StartTransaction();

        /// <summary>
        /// Commits this instance.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollbacks this instance.
        /// </summary>
        void Rollback();

        /// <summary>
        /// Manages the entity validation.
        /// </summary>
        /// <param name="validationRequired">if set to <c>true</c> [validation required].</param>
        void ManageEntityValidation(bool validationRequired);

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Executes the read query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        IEnumerable<T> ExecuteReadQuery<T>(string query) where T : BaseEntity;

        /// <summary>
        /// Executes the scalar read query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>
        /// System.Int32.
        /// </returns>
        int ExecuteScalarReadQuery(string query);

        #endregion Public Methods

        #region Generic Repository Instance

        /// <summary>
        /// Gets the arcadr repository.
        /// </summary>
        /// <value>
        /// The arcadr repository.
        /// </value>
        GenericRepository<Employee> EmployeeRepository { get; }

        GenericRepository<Project> ProjectRepository { get; }

        GenericRepository<Client> ClientRepository { get; }

        GenericRepository<ProjMember> ProjMemberRepository { get; }

        GenericRepository<Designation> DesignationRepository { get; }

        GenericRepository<ResourceUtilization> ResourceUtilizationRepository { get; }

        GenericRepository<Holiday> HolidayRepository { get; }

        GenericRepository<WorkLog1> WorkLogRepository { get; }

        GenericRepository<Invoice> InvoiceRepository { get; }

        GenericRepository<ProjTask> ProjTaskRepository { get; }
        GenericRepository<Phase> PhaseRepository { get; }
        GenericRepository<ProjModule> ProjModuleRepository { get; }
        GenericRepository<WorkLog1> WorkLog1Repository { get; }
        GenericRepository<ProjectTime> ProjectTimeRepository { get; }
        GenericRepository<ProjTaskMaping> ProjTaskMapingRepository { get; }
        GenericRepository<unit> UnitRepository { get; }
        GenericRepository<TechnologyGroup> TechnologyGroupRepository { get; }
        GenericRepository<ResourceConfiguration> ResourceConfigurationRepository { get; }
        
        #endregion Generic Repository Instance
    }
}