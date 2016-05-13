using DataAccess.DAL;
using DataAccess.Repository;
using IshirRecourceUtilization.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ResourceUtilization.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private readonly EmployeeDa _employeeDA;

        public AccountController(EmployeeDa employeeDA)
        {
            _employeeDA = employeeDA;
        }
         
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Resources()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                ProjectDa da = new ProjectDa(new UnitOfWork());

                var employee = _employeeDA.GetEmployee(model.UserName, model.Password);
                if (employee != null)
                {
                    Session["Emp_id"] = employee.Emp_id;
                    Session["UserName"] = employee.UserName;
                    Session["Units"] = employee.Unit;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            Session.Abandon();
            Session["Emp_id"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}