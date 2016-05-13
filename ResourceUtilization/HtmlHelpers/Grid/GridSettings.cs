using System;
using System.Linq;
using System.Web.Mvc;

namespace ResourceUtilization.HtmlHelpers.Grid
{
    /// <summary>
    /// Defines the jqGrid settings.
    /// </summary>
    /// <remarks>
    /// These settings are used for paging and sorting of the grid data.
    /// </remarks>
    [ModelBinder(typeof(GridModelBinder))]
    [Serializable]
    public class GridSettings
    {
        /// <summary>
        /// Gets or sets the page size.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        public int PageSize { get; set; }
        /// <summary>
        /// Gets or sets the page index.
        /// </summary>
        /// <value>
        /// The index of the page.
        /// </value>
        public int PageIndex { get; set; }
        /// <summary>
        /// Gets or sets the sort column.
        /// </summary>
        /// <value>
        /// The sort column.
        /// </value>
        public string SortColumn { get; set; }
        /// <summary>
        /// Gets or sets the sort order.
        /// </summary>
        /// <value>
        /// The sort order.
        /// </value>
        public string SortOrder { get; set; }

        /// <summary>
        /// Initializes a new instance of the GridSettings class.
        /// </summary>
        public GridSettings()
        {
            SortColumn = "ID";
            SortOrder = "DESC";
            PageIndex = 1;
            PageSize = 50;
        }

        /// <summary>
        /// Initializes a new instance of the GridSettings class.
        /// </summary>
        /// <param name="sortColumn">The sort column.</param>
        /// <param name="ascending">Sort ascending flag.</param>
        public GridSettings(string sortColumn, bool ascending)
        {
            SortColumn = sortColumn;
            SortOrder = (ascending ? "ASC" : "DESC");
            PageIndex = 1;
            PageSize = 50;
        }

        /// <summary>
        /// Initializes a new instance of the GridSettings class.
        /// </summary>
        /// <param name="stringData">The string that represents the a GridSettings object.</param>
        public GridSettings(string stringData)
        {
            var tempArray = stringData.Split(new[] { "#;" }, StringSplitOptions.None);
            PageSize = int.Parse(tempArray[0]);
            PageIndex = int.Parse(tempArray[1]);
            SortColumn = tempArray[2];
            SortOrder = tempArray[3];
        }

        /// <summary>
        /// Build a string used to cache the current GridSettings object.
        /// </summary>
        /// <returns>
        /// A string that represents the current GridSettings object.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}#;{1}#;{2}#;{3}",
                PageSize,
                PageIndex,
                SortColumn,
                SortOrder);
        }

        /// <summary>
        /// Load the data from the data source for the current grid settings.
        /// </summary>
        /// <typeparam name="T">The entity type used as data model.</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <param name="count">Returns the number of elements of the returned results.</param>
        /// <returns>
        /// The grid data that match the current grid settings.
        /// </returns>
        public IQueryable<T> LoadGridData<T>(IQueryable<T> dataSource, out int count)
        {
            var query = dataSource;
            //
            // Sorting and Paging by using the current grid settings.
            //
            query = query.OrderBy(SortColumn, SortOrder);
            count = query.Count();
            //
            if (PageIndex < 1)
                PageIndex = 1;
            //
            var data = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            //
            return data;
        }

        /// <summary>
        /// Load the data from the data source for the current grid settings.
        /// </summary>
        /// <typeparam name="T">The entity type used as data model.</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <returns>
        /// The grid data that match the current grid settings.
        /// </returns>
        public IQueryable<T> LoadGridData<T>(IQueryable<T> dataSource)
        {
            var query = dataSource;
            //
            // Sorting and Paging by using the current grid settings.
            //
            query = query.OrderBy(SortColumn, SortOrder);
            //
            if (PageIndex < 1)
                PageIndex = 1;
            //
            var data = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            //
            return data;
        }
    }
}