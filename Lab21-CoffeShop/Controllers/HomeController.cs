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
             CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();

            if (ModelState.IsValid)
            {
               
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

        public ActionResult Admin()
        {
            CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();
            ViewBag.ItemList = ORM.Items.ToList();
            return View();
        }



      public ActionResult AddItem()
        {
            return View();

        }


            public ActionResult AddNewItem(Item newItem)
        {
            
            if (ModelState.IsValid)
            {
                CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();
                ORM.Items.Add(newItem);
               

                ViewBag.ItemList = ORM.Items.ToList();
                ORM.SaveChanges();

                return View();
            }

            else
            {
                return View("Error");
            }
        }
       
        public ActionResult DeleteItem(string Name)
        {

            CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();
            Item Found = ORM.Items.Find(Name);

    
            if (Found != null)
            {
                ORM.Items.Remove(Found);
                ORM.SaveChanges();

                return View();
            }

            else
            {
                return View("Error");
            }


        }
        public ActionResult ItemUpdates (string Name)
        {
            CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();

      
            Item Found = ORM.Items.Find(Name);

            if (Found != null)
            {
                ViewBag.Item = Found;

                return View();

            }
            else
            {
                ViewBag.Error.Message = "Item not found";
                return View("Error");
            }

        }


        public ActionResult EditItem(Item updateItem)
        {
            {
            
                CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();

                Item OldItem = ORM.Items.Find(updateItem.Name);

                if (OldItem != null && ModelState.IsValid)
                {

                    OldItem.Name = updateItem.Name;
                    OldItem.Description = updateItem.Description;
                    OldItem.Quantity = updateItem.Quantity;
                    OldItem.Price = updateItem.Price;


                    ORM.Entry(OldItem).State = System.Data.Entity.EntityState.Modified;

                    ORM.SaveChanges();

                    ViewBag.Message = "Updates have been completed!";
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Something went wrong! Please try again!";
                    return View("Error");
                }
            }




        }
    }
}