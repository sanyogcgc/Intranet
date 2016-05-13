using System;
using System.Web.Configuration;
namespace ResourceUtilization.Utility
{
    /// <summary>
    /// Class Constants.
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Gets the session wrapper.
        /// </summary>
        /// <value>
        /// The session wrapper.
        /// </value>
        public static string SessionWrapper { get { return WebConfigurationManager.AppSettings["SessionWrapper"]; } }

        /// <summary>
        /// Gets the session wrapper.
        /// </summary>
        /// <value>
        /// The session wrapper.
        /// </value>
        public static string SessionUser { get { return WebConfigurationManager.AppSettings["SessionUser"]; } }

        /// <summary>
        /// The sort asc
        /// </summary>
        public const string SortAsc = "asc";
        
        /// <summary>
        /// The sort desc
        /// </summary>
        public const string SortDesc = "descending";
        
        /// <summary>
        /// The success
        /// </summary>
        public const string Success = "success";
        
        /// <summary>
        /// The error
        /// </summary>        
    }
}