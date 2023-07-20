using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;
using ZeroHunger.Models;

namespace ZeroHunger.Controllers
{
    public class RequestController : Controller
    {
       
        // GET: Request
        public ActionResult RequestView()
        {
            var db = new Zero_HungerEntities5();
            var requests = db.Requests.ToList();

            if (requests != null && requests.Count > 0)
            {
                var modelList = requests.Select(r => new RequestDTO()
                {
                    id = r.id,
                    restaurant_name = r.restaurant_name,
                    request_time = r.request_time,
                    maxPreservation_time = r.maxPreservation_time,
                    food_item = r.food_item,
                    Quantity = r.Quantity,
                    address = r.address
                }).ToList();

                return View(modelList);
            }

            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RequestDTO request)
        {
            if (ModelState.IsValid)
            {
                var db = new Zero_HungerEntities5();
                db.Requests.Add(Convert(request));
                db.SaveChanges();
                ViewBag.msg = "Successfully Requested";
                return RedirectToAction("RequestView");
            }

            return View(request);
        }

        private Request Convert(RequestDTO request)
        {
            var req = new Request()
            {
                id = request.id,
                restaurant_name = request.restaurant_name,
                request_time = request.request_time,
                maxPreservation_time = request.maxPreservation_time,
                food_item = request.food_item,
                Quantity = request.Quantity,
                address = request.address
            };
            return req;
        }
        RequestDTO Convert(Request request)
        {
            var req = new RequestDTO()
            {
                id = request.id,
                restaurant_name = request.restaurant_name,
                request_time = request.request_time,
                maxPreservation_time = request.maxPreservation_time,
                food_item = request.food_item,
                Quantity = request.Quantity,
                address = request.address
            };
            return req;
        }

    }
}
