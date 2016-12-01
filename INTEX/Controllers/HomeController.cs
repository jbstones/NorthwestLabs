using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        //GET
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Username"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(email, "Employee") && (string.Equals(password, "Password")))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Employee", "Home");

            }
            else
            {
                return View();
            }


        }

        // GET
        [Authorize]
        public ActionResult Employee()
        {

            return View();
        }

        public ActionResult Assays()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            return View();
        }

        public ActionResult YourAccount()
        {
            return View();
        }

        //SINGAPORE VIEWS
        public ActionResult SingaporeIndex()
        {
            return View();
        }

        public ActionResult WorkOrderSingapore()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult Logs()
        {
            return View();
        }

        public ActionResult Results()
        {
            return View();
        }

        //SEATTLE VIEWS
        public ActionResult SeattleIndex()
        {
            return View();
        }

        public ActionResult WorkOrderSeattle()
        {
            return View();
        }

        public ActionResult Reports()
        {
            return View();
        }

        public ActionResult CustomerAccounts()
        {
            return View();
        }

        public ActionResult EmployeeViewCatalog()
        {
            return View();
        }
    }
}