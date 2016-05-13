using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class BaseDa : IDisposable
    {
        /// <summary>
        /// Gets or sets the unit of work.
        /// </summary>
        /// <value>The unit of work.</value>
        public IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        /// Starts the transaction.
        /// </summary>
        public void StartTransaction()
        {
            UnitOfWork.StartTransaction();
        }

        /// <summary>
        /// Commits the transaction.
        /// </summary>
        public void CommitTransaction()
        {
            UnitOfWork.Commit();
        }

        /// <summary>
        /// Rollbacks the transaction.
        /// </summary>
        public void RollbackTransaction()
        {
            UnitOfWork.Rollback();
        }

        #region Constructor(s)

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDa"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        protected BaseDa(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Constructor for the data access.
        /// </summary>
        protected BaseDa()
        {
            disposed = false;
            UnitOfWork = new UnitOfWork();
        }

        #endregion Constructor(s)

        #region Dispose

        /// <summary>
        /// The disposed
        /// </summary>
        private bool disposed;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only
        /// unmanaged resources.</param>
        private void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                {
                    UnitOfWork.Dispose();
                }
            disposed = true;
        }

        #endregion Dispose

        #region Common Methods
        public void GetWeek(int weeknumber, int year,out DateTime  startDate, out DateTime endDate)
        {
            DateTime dt = new DateTime(year, 1, 1).AddDays((weeknumber) * 7);
            while (dt.DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                dt = dt.AddDays(-1);

            startDate = dt;// dt.AddDays(1);
            endDate = dt.AddDays(7);
        }

        public int GetWeekHours(int weekNumber, int year)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            GetWeek(weekNumber, year, out startDate, out endDate);

            var holiday = from hld in UnitOfWork.HolidayRepository.GetQuery()
                          where hld.Restricted_Holiday == "False" && hld.Holiday_Date >= startDate && hld.Holiday_Date <= endDate
                          select new { hld.Holiday_Date };

            var weekHours = (5 - holiday.Count()) * 8;
            return weekHours;
        }

        #endregion
    }
}