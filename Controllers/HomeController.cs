using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    [Authorize]
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
        [AllowAnonymous]
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";
            ViewBag.ReturnUrl = "Employees/Index";
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            //FormCollection post
            //string userName, string password
            if (ModelState.IsValid)
            {

                //Employee employee = new Employee();
                //employee.Username = userName;
                //employee.PasswordSalt = Utility.CreateSalt();
                //employee.Auth = "1";
                //employee.Password = Utility.GenerateHashWithSalt(password, employee.PasswordSalt);
                //db.Employee.Add(employee);
                //db.SaveChanges();

                //Employee employee = ValidateUser(userName, password);
                //if (employee != null)
                //{
                //    //Utility.GetPerssion(member);
                //    string userData = JsonConvert.SerializeObject(employee);
                //    Utility.SetAuthenTicket(userData, userName);
                //    return RedirectToAction("Index", "Employees");
                //}

                Employee employee = ValidateUser(loginViewModel.userName, loginViewModel.password);
                if (employee != null)
                {
                    //Utility.GetPerssion(member);
                    string userData = JsonConvert.SerializeObject(employee);
                    Utility.SetAuthenTicket(userData, loginViewModel.userName);
                    return RedirectToAction("Index", "Employees");
                }
                ViewBag.message = "登入失敗!";
                return View();
            }
            ViewBag.message = "登入失敗!";
            return View();

        }
        private Employee ValidateUser(string userName, string password)
        {
            Employee employee = db.Employee.SingleOrDefault(o => o.Username == userName);
            if (employee == null)
            {
                return null;
            }
            string saltPassword = Utility.GenerateHashWithSalt(password, employee.PasswordSalt);
            return saltPassword == employee.Password ? employee : null;
        }

        public ActionResult LogOff()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}