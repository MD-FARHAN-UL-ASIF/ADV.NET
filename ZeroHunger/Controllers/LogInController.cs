using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;
using ZeroHunger.Models;

namespace ZeroHunger.Controllers
{
    public class LogInController : Controller
    {
        // GET: Login
        public ActionResult EmployeeLogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeLogIn(EmployeeLogInDTO emlog)
        {
            var db = new Zero_HungerEntities5();
            var employee = (from e in db.Employees
                            where e.email.Equals(emlog.email) && e.password.Equals(emlog.password)
                            select e).SingleOrDefault();

            if (employee != null)
            {
                if (employee.position == "Volunteer")
                {
                    Session["employeeEmail"] = employee.email;
                    return RedirectToAction("Volunteer", "Dashboard");
                }
                else if (employee.position == "Employee")
                {
                    Session["employeeEmail"] = employee.email;
                    return RedirectToAction("Employee", "Dashboard");
                }
                else if (employee.position == "Admin")
                {
                    Session["employeeEmail"] = employee.email;
                    return RedirectToAction("Admin", "Dashboard");
                }
            }


            return View();
        }
        [HttpGet]
        public ActionResult RestaurantLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RestaurantLogIn(RestaurantLogInDTO reslog)
        {
            var db = new Zero_HungerEntities5();
            var we = (from rest in db.Restaurants
                        where rest.email.Equals(reslog.email) && rest.password.Equals(reslog.password)
                        select rest).SingleOrDefault();
            if (we != null)
            {
                Session["restaurantEmail"] = we.email;
                return RedirectToAction("Restaurant", "Dashboard");
            }
            return View();
        }
    }
}
