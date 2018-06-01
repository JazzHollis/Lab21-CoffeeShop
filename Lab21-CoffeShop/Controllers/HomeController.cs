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
            CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();
            ViewBag.ItemList = ORM.Items.ToList();
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

        public ActionResult AddNewUser(User newUser)
        {

         

            if (ModelState.IsValid)
            {
                CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();
                ORM.Users.Add(newUser);
                ORM.SaveChanges();

                ViewBag.Message = $"Welcome {newUser.First_Name}!";

                return View("Confirm");
            }

            else
            {  
                return View("Error");
            }

  
        }
    }
}