using DataAccess.DAL;
using DataAccess.Repository;
using ResourceUtilization.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResourceUtilization
{
    public class ControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            if (controllerName == "Account")
                return new AccountController(new EmployeeDa(new UnitOfWork()));
            else if (controllerName == "Report")
                return new ReportController();
            else if (controllerName == "WorkLog")
                return new WorkLogController();
            else if (controllerName == "ResourceConfiguration")
                return new ResourceConfigurationController();
            else if (controllerName == "ReportConfiguration")
                return new ReportConfigurationController();
            else
                return new HomeController();
        }
    }
}