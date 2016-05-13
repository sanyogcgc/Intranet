using ResourceUtilization.Utility;
using System.Web.Mvc;

namespace ResourceUtilization.HtmlHelpers.Grid
{
    /// <summary>
    /// Defines the Grid model binder.
    /// </summary>
    public class GridModelBinder : IModelBinder
    {
        /// <summary>
        /// Bind the grid settings to the jqGrid params.
        /// </summary>
        /// <param name="controllerContext">The controller context.</param>
        /// <param name="bindingContext">The binding context.</param>
        /// <returns>
        /// The grid settings for the current jqGrid params.
        /// </returns>
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            try
            {
                var request = controllerContext.HttpContext.Request;
                return new GridSettings
                {
                    PageIndex = int.Parse(request["page"] ?? "1"),
                    PageSize = int.Parse(request["rows"] ?? "50"),
                    SortColumn = request["sidx"] ?? "",
                    SortOrder = request["sord"] ?? Constants.SortAsc,
                };
            }
            catch
            {
                return null;
            }
        }
    }
}