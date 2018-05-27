using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21_CoffeShop.Models;


namespace Lab21_CoffeShop.Controllers
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

        public ActionResult UserRegistration()
        {
            ViewBag.Message = "Please fill out the form to register!";
            return View();
        }

        public ActionResult AddNewUser(UserInfo newUser)
        {

            if (ModelState.IsValid)
            {

                ViewBag.Message = $"Welcome {newUser.Firstname}!";
                return View("Confirm");
            }

            else
            {  
                return View("Error");
            }
        }
    }
}