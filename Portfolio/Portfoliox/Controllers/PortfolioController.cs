using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            string name = "Md. Farhan Ul Asif";
            string email = "farhanchowdhury66@gmail.com";
            string bio = "I fall, I rise, I make mistake, I live, I learn, I've been hurt but I'm alive.!🌸";
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Bio = bio;
            return View();
        }

        public ActionResult Profile()
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Name = "Md. Farhan Ul Asif";
            myProfile.DOB = new DateTime(2001, 11, 10);
            myProfile.Nation = "Bangladeshi";
            myProfile.BloodGroup = "B+";
            myProfile.Address = "Dhaka, Bangladesh";
            myProfile.ContactNo = "01741958885";
            myProfile.Hobbies = new string[] { "reading", "travelling", "gaming" };
            return View(myProfile);
        }
        public ActionResult Education()
        {
            MyEducation[] myEducation = new MyEducation[]
            {
                new MyEducation
                {
                    Degree = "BSC", Institution = "AIUB", Year = "4th year"
                },
                new MyEducation
                {
                    Degree = "HSC", Institution = "Cantonment College Jashore", Year = "2019"
                },
                new MyEducation
                {
                    Degree = "SSC", Institution = "Satkhira Govt. High School", Year = "2017"                }
            };

            ViewBag.Education = myEducation;

            return View();
        }

        public ActionResult Projects()
        {
            MyProjects[] myProjects = new MyProjects[]
            {
                new MyProjects
                {
                    Serial = 1, Course = "Advanced Programming With Java", Description = "Catering Management System"
                },
                new MyProjects
                {
                    Serial = 2, Course = "OOP2", Description = "Super Market Management system"
                },
                new MyProjects
                {
                    Serial = 3, Course = "Web Technologies", Description = "Hospital Management System"
                },
                new MyProjects
                {
                    Serial = 4, Course = "OOP1", Description = "Restaurant Management System"
                }
            };


            return View(myProjects);
        }
        public ActionResult Reference()
        {
            return View();
        }
    }
}