using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private Model db = new Model();
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
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your Dashboard page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";
            ViewBag.ReturnUrl = "Employees/Index";
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string userName, string password)
        {
            if (ModelState.IsValid)
            {
                //Member member = ValidateUser(userName, password);
                //if (member != null)
                //{
                //    Utility.GetPerssion(member);
                //    string userData = JsonConvert.SerializeObject(member);
                //    Utility.SetAuthenTicket(userData, userName);
                    return RedirectToAction("Index", "Employees");
                //}
                //ViewBag.message = "登入失敗!";
                //return View();
            }
            ViewBag.message = "登入失敗!";
            return View();

        }
    }
}