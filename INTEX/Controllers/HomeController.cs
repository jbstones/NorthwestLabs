using INTEX.DAL;
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
        private NorthwestContext db = new NorthwestContext();

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

            if (string.Equals(email, "Employee") && (string.Equals(password, "Login")))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Employee", "Home");

            }
            else
            {
                return View();
            }
        }

        public ActionResult LoginCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginCustomer(FormCollection form, bool rememberMe = false)
        {
            String email = form["Username"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(email, "Customer") && (string.Equals(password, "Login")))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Customer", "Home");

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

        //GET
        [Authorize]
        public ActionResult Customer()
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

        //CUSTOMER VIEWS
        public ActionResult WorkOrder()
        {
            return View();
        }

        public ActionResult ExistingWorkOrder()
        {
            return View();
        }

        public ActionResult AccountBalance()
        {
            return View();
        }

        public ActionResult MakeAPayment()
        {
            return View();
        }

        public ActionResult Orderconfirmation()
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

        public ActionResult SummaryReport()
        {
            return View();
        }
    }
}