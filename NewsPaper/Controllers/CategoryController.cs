using NewsPaper.EF;
using NewsPaper.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPaper.Controllers
{
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("api/category/all")]
        public HttpResponseMessage All()
        {
            var db = new NPContext();
            var data = db.Categories.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/category/create")]

        public HttpResponseMessage create(Category cat)
        {
            var db = new NPContext();
            try
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created Successfully" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/category/update")]
        public HttpResponseMessage Update(Category upda) {
            var db = new NPContext();
            var excategory = db.Categories.Find(upda.id);
            db.Entry(excategory).CurrentValues.SetValues(upda);
            try
            {
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated Successfully" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/category/delete")]
        public HttpResponseMessage Delete(Category del)
        {
            var db = new NPContext();
            var excategory = db.Categories.Find(del.id);
            
            try
            {
                db.Categories.Remove(excategory);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted Successfully" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/category/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var db = new NPContext();
            var data = db.Categories.Find(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}