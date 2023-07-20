using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI;
using ZeroHunger.DB;
using ZeroHunger.Models;

namespace ZeroHunger.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult EmployeeProfile()
        {
            var db = new Zero_HungerEntities5();
            var employee = db.Employees.ToList();

            if (employee != null && employee.Count > 0)
            {
                var modelList = employee.Select(e => new EmployeeDTO()
                {
                    id = e.id,
                    firstname = e.firstname,
                    lastname = e.lastname,
                    email = e.email,
                    gender = e.gender,
                    phone = e.phone,
                    position = e.position,
                    address = e.address,
                    age = e.age,
                    password = e.password
                }).ToList();

                return View(modelList);
            }

            return View();
        }
        // GET: Registration
        [HttpGet]
        public ActionResult EmployeeRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeRegistration(EmployeeDTO employee)
        {
            if(ModelState.IsValid) 
            {
                var db = new Zero_HungerEntities5();
                db.Employees.Add(Convert(employee));
                db.SaveChanges();
                return RedirectToAction("EmployeeLogIn", "Login");
            }
            return View();
        }

        [HttpGet]
        public ActionResult RestaurantRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RestaurantRegistration(RestaurantDTO restaurant)
        {
            if (ModelState.IsValid)
            {
                var db = new Zero_HungerEntities5();
                db.Restaurants.Add(Convert(restaurant));
                db.SaveChanges();
                return RedirectToAction("RestaurantLogIn", "Login");
            }
            return View();
        }


        Employee Convert(EmployeeDTO employee) 
        {
            var emp = new Employee()
            {
              id = employee.id,
              firstname = employee.firstname,
              lastname = employee.lastname,
              email = employee.email,
              gender = employee.gender,
              phone = employee.phone,
              position = employee.position,
              address = employee.address,
              age = employee.age,
              password = employee.password
            };
            return emp;
        }
        EmployeeDTO Convert(Employee employee)
        {
            var emp = new EmployeeDTO()
            {
                id = employee.id,
                firstname = employee.firstname,
                lastname = employee.lastname,
                email = employee.email,
                gender = employee.gender,
                phone = employee.phone,
                position = employee.position,
                address = employee.address,
                age = employee.age,
                password = employee.password
            };
            return emp;
        }
        List<EmployeeDTO> Convert(List<Employee> employees)
        {
            var emps = new List<EmployeeDTO>();
            foreach (var item in employees) 
            {
                emps.Add(Convert(item));
            }
            return emps;
        }
        Restaurant Convert(RestaurantDTO restaurant)
        {
            var res = new Restaurant()
            {
                id = restaurant.id,
                name = restaurant.name,
                address = restaurant.address,   
                contact = restaurant.contact,
                email = restaurant.email,
                type = restaurant.type,
                password = restaurant.password
            };
            return res;
        }
        RestaurantDTO Convert(Restaurant restaurant)
        {
            var res = new RestaurantDTO()
            {
                id=restaurant.id,
                name = restaurant.name,
                address = restaurant.address,
                contact = restaurant.contact,
                email = restaurant.email,
                type = restaurant.type,
                password = restaurant.password
            };
            return res;
        }
        List<RestaurantDTO> Convert(List<Restaurant> restaurants)
        {
            var rest = new List<RestaurantDTO>();
            foreach (var item in restaurants)
            {
                rest.Add(Convert(item));
            }
            return rest;
        }

    }
}